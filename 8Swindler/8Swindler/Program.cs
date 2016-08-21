using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//文本文件的读写，StreamWriter && StreamReader
namespace _8Swindler
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"D:\Programme\GitHub\VCE\8Swindler\8Swindler\file\secret_plan.txt");
            sw.WriteLine("How I'll defeat Captain Amazing");
            sw.WriteLine("Another genius secret plan by The Swindler");
            sw.Write("I'll create an army of clones and ");
            sw.WriteLine("unleash them upon the citizens of objectville.");
            string location = "the mall";
            for (int number = 0; number <= 6; number++)
            {
                sw.WriteLine("Clone #{0} attacks {1}", number, location);
                if (location == "the mall")
                {
                    location = "downtown";
                }
                else
                {
                    location = "the mall";
                }
            }
            sw.Close();

            StreamReader reader = new StreamReader(@"D:\Programme\GitHub\VCE\8Swindler\8Swindler\file\secret_plan.txt");
            StreamWriter writer = new StreamWriter(@"D:\Programme\GitHub\VCE\8Swindler\8Swindler\file\emailToCaptainAmazing.txt");
            writer.WriteLine("To: CaptainAmazing@objectille.net");
            writer.WriteLine("From: Commissioner@objectiville.net");
            writer.WriteLine("Subject: Can you save the day... again?");
            writer.WriteLine();
            writer.WriteLine("We've discovered the Swindler's plan");
            while (!reader.EndOfStream)
            {
                string lineFromThePlan = reader.ReadLine();
                writer.WriteLine("The plan -> " + lineFromThePlan);
            }
            writer.WriteLine();
            writer.WriteLine("Can you help us?");
            writer.Close();
            reader.Close();
        }
    }
}
