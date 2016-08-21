using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WriteAndReadDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Deck deckWrite = new Deck(random);
            deckWrite.WriteCards(@"..\test.txt");
            Deck deckRead = new Deck(@"..\test.txt");
            foreach (string card in deckRead.GetCardNames())
            {
                Console.WriteLine(card);
            }
        }
    }
}
