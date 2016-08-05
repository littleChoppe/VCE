using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//一些基础知识
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //关于Convert第二个参数是以什么进制进行输出
            string binaryValue = Convert.ToString(217, 2);
            int intValue = Convert.ToInt32(binaryValue, 2);
            Console.WriteLine("Binary {0} is integer {1}", binaryValue, intValue);

            //对于布尔值来说 &和&& 之间，以及 |和|| 之间唯一的区别是这些不会短路。
            int val1 = Convert.ToInt32("100000001", 2);
            int val2 = Convert.ToInt32("001010100", 2);
            int or = val1 | val2;
            int and = val1 & val2;
            int xor = val1 ^ val2;
            int not = ~val1;

            //PadLeft(9, '0')的意思是使用第二个参数的字符补充字符串使其长度为第一参数
            Console.WriteLine("val1: {0}", Convert.ToString(val1, 2));
            Console.WriteLine("val2: {0}", Convert.ToString(val2, 2).PadLeft(9, '0'));
            Console.WriteLine("  or: {0}", Convert.ToString(or, 2).PadLeft(9, '0'));
            Console.WriteLine(" and: {0}", Convert.ToString(and, 2).PadLeft(9, '0'));
            Console.WriteLine(" xor: {0}", Convert.ToString(xor, 2).PadLeft(9, '0'));
            Console.WriteLine(" not: {0}", Convert.ToString(not, 2).PadLeft(9, '0'));
        }
    }
}
