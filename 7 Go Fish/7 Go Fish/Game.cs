using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7_Go_Fish
{
    class Game
    {
        private List<Player> players;
        private Dictionary<Values, Player> books;
        private Deck stock;
        private TextBox textProgress;

        public Game(string playerName, IEnumerable<string> opponentNames, TextBox textProgress)
        {
            Random random = new Random();
            this.textProgress = textProgress;
            players = new List<Player>();
            players.Add(new Player(playerName, random, textProgress));
            foreach (string player in opponentNames)
            {
                players.Add(new Player(player, random, textProgress));
            }
            books = new Dictionary<Values, Player>();
            stock = new Deck();
            Deal();
            players[0].SortHand();
        }

        /// <summary>
        /// 洗牌，发牌，抽出套牌
        /// </summary>
        private void Deal()
        {
            stock.Shuffle();
            for (int i = 0; i < 5; i++)
            {
                foreach (Player player in players)
                {
                    player.TakeCard(stock.Deal());
                }
            }
            foreach (Player player in players)
            {
                PullOutBook(player);
            }
        }

        public IEnumerable<string> GetPlayerCardNames()
        {
            return players[0].GetCardName();
        }

        /// <summary>
        /// 描述每个人有多少张牌，剩下的牌数
        /// </summary>
        /// <returns></returns>
        public string DescribePlayerHands()
        {
            string description = "";
            for (int i = 0; i < players.Count; i++)
            {
                description += players[i].Name + " has " + players[i].CardCount;
                if (players[i].CardCount == 1)
                    description += " card." + Environment.NewLine;
                else
                    description += " cards." + Environment.NewLine;
            }
            description += "The stock has " + stock.Count + " cards left.";
            return description;
        }

        /// <summary>
        /// 描述谁有什么样的套牌
        /// </summary>
        /// <returns></returns>
        public string DescribeBooks()
        {
            string whoHasBooks = "";
            foreach (Values value in books.Keys)
            {
                whoHasBooks += books[value].Name + " has a book of " + Card.Plural(value) + Environment.NewLine;
            }
            return whoHasBooks;
        }

        /// <summary>
        /// 把一个玩家的所有套牌存进套牌字典中，如果玩家手上没牌则返回真
        /// </summary>
        /// <param name="player"></param>
        /// <returns>如果玩家手上没牌则返回真</returns>
        public bool PullOutBook(Player player)
        {
            IEnumerable<Values> booksPulled = player.PullOutBooks();
            foreach (Values value in booksPulled)
            {
                books.Add(value, player);
            }
            if (player.CardCount == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 游戏从人类玩家开始，一轮游戏为所有玩家都问过其他玩家要牌，
        /// 每一次问完牌以后都要取出套牌，
        /// 如果玩家取出套牌以后没有牌或者，一轮过后没有牌则从剩余那里抽5张
        /// 当剩余没有牌以后游戏结束，返回真
        /// </summary>
        /// <param name="selectedPlayerCard"></param>
        /// <returns>剩余没有牌就返回真</returns>
        public bool PlayOneRound(int selectedPlayerCard)
        {
            Values cardToAskFor = players[0].Peek(selectedPlayerCard).Value;
            for (int i = 0; i < players.Count; i++)
            {
                //问牌
                if (i == 0)
                    players[0].AskForCard(players, 0, stock, cardToAskFor);
                else
                    players[i].AskForCard(players, i, stock);

                if (PullOutBook(players[i]))    //取套牌
                {
                    //没有牌就取牌
                    textProgress.Text += players[i].Name + " drew a new hand" + Environment.NewLine;
                    int card = 1;
                    while (card <= 5 && stock.Count > 0)
                    {
                        players[i].TakeCard(stock.Deal());
                        card++;
                    }
                }
                players[0].SortHand();
                if (stock.Count == 0)
                {
                    textProgress.Text = "The stock is out of cards. Game over!" + Environment.NewLine;
                    return true;
                }
            }
            return false;
        }

        public string GetWinnerName()
        {
            Dictionary<string, int> winners = new Dictionary<string, int>();
            foreach (Values value in books.Keys)
            {
                string name = books[value].Name;
                if (winners.ContainsKey(name))
                    winners[name]++;
                else
                    winners.Add(name, 1);
            }

            int mostBooks = 0;
            foreach (string name in winners.Keys)
            {
                if (winners[name] > mostBooks)
                    mostBooks = winners[name];
            }

            bool tie = false;
            string winnerList = "";
            foreach (string name in winners.Keys)
            {
                if (winners[name] == mostBooks)
                {
                    if (!string.IsNullOrEmpty(winnerList))
                    {
                        winnerList += " and ";
                        tie = true;
                    }
                    winnerList += name;
                }
            }
            winnerList += " with " + mostBooks + " books";
            if (tie)
                return "A tie between " + winnerList;
            else
                return winnerList;
        }
    }
}
