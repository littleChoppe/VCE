using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//协变，使用 IEnumerable 向上强制转换， 把 ducks 集合转换成 birds
namespace _7DuckToBird
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            IEnumerable<Bird> upcastDucks = ducks;
            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() { Name = "George" });

            foreach (Bird bird in birds)
                Console.WriteLine(bird);
        }
    }
}
