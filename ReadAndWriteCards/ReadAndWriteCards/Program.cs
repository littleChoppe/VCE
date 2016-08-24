using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ReadAndWriteCards
{
    class Program
    {
        static void Main(string[] args)
        {
            //串行化读文件
            Card ThreeOfClubs = new Card(Suits.Clubs, Values.Three);
            Card SixOfHearts = new Card(Suits.Hearts, Values.Six);

            using (Stream output1 = File.Create("three-c.dat"))
            using (Stream output2 = File.Create("six-h.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output1, ThreeOfClubs);
                bf.Serialize(output2, SixOfHearts);
            }

            //比较文件的不同
            /*
             * Byte #282: 1 versus 3
             * Byte #334: 3 versus 6
             */
            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");
            for (int i = 0; i < firstFile.Length; i++)
            {
                if (firstFile[i] != secondFile[i])
                {
                    Console.WriteLine("Byte #{0}: {1} versus {2}", i, firstFile[i], secondFile[i]);
                }
            }

            //改写文件
            firstFile[282] = (byte)Suits.Spades;
            firstFile[334] = (byte)Values.King;
            File.Delete("king-s.dat");
            File.WriteAllBytes("king-s.dat", firstFile);

            //逆串行化
            using (Stream input = File.OpenRead("king-s.dat"))
            {
                BinaryFormatter bf= new BinaryFormatter();
                Card kingS = (Card)bf.Deserialize(input);
                Console.WriteLine(kingS.Name);
            }
        }
    }
}
