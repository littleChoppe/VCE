using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializableCards
{
    [Serializable]
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public int Count { get { return cards.Count; } }

        /// <summary>
        /// 构造一副完整的牌
        /// </summary>
        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cards.Add(new Card((Suits)suit, (Values)value));
                }
            }
        }

        /// <summary>
        /// 构造一个牌集合
        /// </summary>
        /// <param name="initialCards">传入一个牌集合</param>
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        /// <summary>
        /// 返回一个描述卡片列表的字符串列表
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                CardNames[i] = cards[i].Name;
            }
            return CardNames;
        }

        /// <summary>
        /// 是否包含某一张牌
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CantainsValue(Values value)
        {
            foreach (Card card in cards)
            {
                if (card.Value == value)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 根据索引返回某一张牌
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns>返回一张牌</returns>
        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
        }

        /// <summary>
        /// 洗牌
        /// </summary>
        public void Shuffle()
        {
            List<Card> NewCards = new List<Card>();
            while (cards.Count > 0)
            {
                int cardToMove = random.Next(cards.Count);
                NewCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = NewCards;
        }

        /// <summary>
        /// 根据牌值排序
        /// </summary>
        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }

        /// <summary>
        /// 根据索引删除一张牌，返回被删除的牌
        /// </summary>
        /// <param name="index">删除牌的索引</param>
        /// <returns>返回被删除的牌</returns>
        public Card Deal(int index)
        {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
        }

        /// <summary>
        /// 重载删除牌，若不给索引，默认删除第一张牌
        /// </summary>
        /// <returns>返回第一张牌</returns>
        public Card Deal()
        {
            return Deal(0);
        }

        /// <summary>
        /// 从一手牌中抽出符合值的牌，也就是在手牌中删除这些牌，并把这些牌存下来形成一个集合
        /// </summary>
        /// <param name="value"></param>
        /// <returns>返回符合值的那些牌（一个集合）</returns>
        public Deck PullOutValue(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });
            for (int i = cards.Count - 1; i >= 0; i--)
            {
                if (cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            }
            return deckToReturn;
        }

        /// <summary>
        /// 一手牌中是否有一套牌
        /// </summary>
        /// <param name="value"></param>
        /// <returns>有一套牌返回true，否则返回false</returns>
        public bool HasBooks(Values value)
        {
            int NumberOfCards = 0;
            foreach (Card card in cards)
            {
                if (card.Value == value)
                    NumberOfCards++;
            }
            if (NumberOfCards == 4)
                return true;
            else
                return false;
        }
    }
}
