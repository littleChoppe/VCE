﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//方法重载
namespace _7CardOverload
{
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }

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

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }
    }
}
