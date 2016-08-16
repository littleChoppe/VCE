using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7DuckToBird
{
    class Penguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguins can't fly!");
        }

        public override string ToString()
        {
            return "A penguin named " + base.Name;
        }
    }
}
