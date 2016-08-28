using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//扩展密封类的方法
namespace HumenExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman steve = new OrdinaryHuman(185);
            Console.WriteLine(steve.BreakWalls(89.2));
        }
    }
}
