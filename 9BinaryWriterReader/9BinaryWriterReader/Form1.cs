using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

//使用BinaryWriter读写二进制数据
namespace BinaryWriterReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intValue = 48769414;
            string stringValue = "Hello";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695F;
            char charValue = 'E';

            using (FileStream output = File.Create("binarydata.dat"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(intValue);
                writer.Write(stringValue);
                writer.Write(byteArray);
                writer.Write(floatValue);
                writer.Write(charValue);
            }

            byte[] dataWritten = File.ReadAllBytes("binarydata.dat");
            foreach (byte b in dataWritten)
            {
                Console.Write("{0:x2} ", b);
            }
            Console.WriteLine("- {0} bytes", dataWritten.Length);

            byte[] floatArr = BitConverter.GetBytes(floatValue);
            foreach (byte b in floatArr)
            {
                Console.Write("{0:x2} ", b);
            }
        }

        private void read_Click(object sender, EventArgs e)
        {
            using (FileStream input = File.OpenRead("binarydata.dat"))
            using (BinaryReader reader = new BinaryReader(input))
            {
                int intRead = reader.ReadInt32();
                string stringRead = reader.ReadString();
                byte[] byteArrayRead = reader.ReadBytes(4);
                float floatRead = reader.ReadSingle();
                char charRead = reader.ReadChar();
                Console.Write("int: {0} string: {1} bytes: ", intRead, stringRead);
                foreach (byte b in byteArrayRead)
                {
                    Console.Write("{0} ", b);
                }
                Console.Write("float: {0} char: {1} ", floatRead, charRead);
            }
        }
    }
}
