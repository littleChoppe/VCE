using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7CardSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }

            foreach (Card card in cards)
            {
                Console.WriteLine(card);
            }

            Console.ReadKey();
        }
    }
}
