using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReadAndWriteCards
{
    [Serializable]
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }

    [Serializable]
    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Teen = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }

    [Serializable]
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }

        public string Name { get { return Value + " of " + Suit; } }

        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// 根据值返回描述的复数形式
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}
