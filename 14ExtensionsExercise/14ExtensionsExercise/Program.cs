using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyExtensions;

namespace ExtensionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Clones are wreaking havoc at the factory. Help!";
            message.IsDistressCall();
            Console.WriteLine(message);
        }
    }
}
