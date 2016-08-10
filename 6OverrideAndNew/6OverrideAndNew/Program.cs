using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//子类中覆盖方法与隐藏方法的区别
//目标是使控制台输出小偷偷走了宝石
namespace _6OverrideAndNew
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();

            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
