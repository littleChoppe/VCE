using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//泛型List<T>
namespace _7Shoes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shoe> shoeCloset = new List<Shoe>()
            {
                new Shoe() { Style = Style.Sneakers, Color = Color.Black },
                new Shoe() { Style = Style.Clogs, Color = Color.Brown },
                new Shoe() { Style = Style.Wingtips, Color = Color.Black },
                new Shoe() { Style = Style.Loafers, Color = Color.White },
                new Shoe() { Style = Style.Loafers, Color = Color.Red },
                new Shoe() { Style = Style.Sneakers, Color = Color.Green },
            };

            int numberOfShoes = shoeCloset.Count;
            foreach (Shoe shoe in shoeCloset)
            {
                shoe.Style = Style.Flipflops;
                shoe.Color = Color.Orange;
            }

            shoeCloset.RemoveAt(4);

            Shoe thirdShoe = shoeCloset[3];
            Shoe secondShoe = shoeCloset[2];
            shoeCloset.Clear();

            shoeCloset.Add(thirdShoe);
            if (shoeCloset.Contains(secondShoe))
                Console.WriteLine("That's surprising.");
        }
    }
}
