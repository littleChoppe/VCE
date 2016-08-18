using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_Go_Fish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private TextBox textProgress;

        public int CardCount { get { return cards.Count; } }

        public Player(string name, Random random, TextBox textProgress)
        {
            this.name = name;
            this.random = random;
            this.cards = new Deck(new Card[] {} );
            this.textProgress = textProgress;
            this.textProgress.Text += name + " has just joined the game" + Environment.NewLine;
        }

        /// <summary>
        /// 添加一张牌进自己的一手牌
        /// </summary>
        /// <param name="card"></param>
        public void TakeCard(Card card) 
        {
            cards.Add(card);
        }

        /// <summary>
        /// 返回自己一手牌的描述
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetCardName()
        {
            return cards.GetCardNames();
        }

        /// <summary>
        /// 按照索引查看一张牌
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns>返回索引的一张牌</returns>
        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }

        public void SortHand()
        {
            cards.SortByValue();
        }

        /// <summary>
        /// 从一手牌中删除掉所有套牌
        /// </summary>
        /// <returns>返回被删除的套牌的值的集合</returns>
        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();
            for (int i = 1; i <= 13; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                        howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    for (int card = cards.Count - 1; card >= 0; card--)
                    {
                        if (cards.Peek(card).Value == value)
                            cards.Deal(card);
                    }
                }
            }
            return books;
        }

        /// <summary>
        /// 从手中的牌中随机选择一张
        /// </summary>
        /// <returns>返回随机牌的值</returns>
        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Value;
        }

        /// <summary>
        /// 查看手中是否有等于某值的牌，描述有这些牌的张数，返回这些牌，并从手中牌中删除这些牌
        /// </summary>
        /// <param name="value"></param>
        /// <returns>返回等于某值的牌的集合</returns>
        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutValue(value);
            textProgress.Text += Name + " has " + cardsIHave.Count + " " + Card.Plural(value) + Environment.NewLine;
            return cardsIHave;
        }

        /// <summary>
        /// 人类玩家问牌
        /// </summary>
        /// <param name="players"></param>
        /// <param name="myIndex"></param>
        /// <param name="stock"></param>
        /// <param name="value"></param>
        public void AskForCard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            this.textProgress.Text += this.name + " asks if anyone has a " + value + Environment.NewLine;
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck cardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += cardsGiven.Count;
                    while (cardsGiven.Count > 0)
                        cards.Add(cardsGiven.Deal());
                }
            }

            if (totalCardsGiven == 0)
            {
                textProgress.Text += this.name + " must draw from the stock." + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }

        /// <summary>
        /// 计算机玩家问牌
        /// </summary>
        /// <param name="players"></param>
        /// <param name="myIndex"></param>
        /// <param name="stock"></param>
        public void AskForCard(List<Player> players, int myIndex, Deck stock)
        {
            Values randomValue = GetRandomValue();
            AskForCard(players, myIndex, stock, randomValue);
        }
    }
}
