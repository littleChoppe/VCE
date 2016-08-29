using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Type练习
namespace TypeExamples
{

    class Program
    {
        class NestedClass
        {
            public class DoubleNestedClass
            { 
            }
        }

        static void Main(string[] args)
        {
            Type nestedClassType = typeof(NestedClass.DoubleNestedClass);
            Console.WriteLine(nestedClassType.FullName);

            List<string> stringList = new List<string>();
            Console.WriteLine(stringList.GetType().Name);
        }
    }
}
