using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//引用参数以及可选参数
namespace Ref
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ModifyAndButon(ref int value, ref Button button)
        {
            int i = value;
            i *= 5;
            value = i - 3;
            button = button1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int q = 100;
            Button b = button3;
            ModifyAndButon(ref q, ref b);
            Console.WriteLine("q = {0}, b.Text = {1}", q, b.Text);
        }

        void CheckTemperature(double temperature, double tooHigh = 99.5, double tooLow = 96.5)
        {
            if (temperature < tooHigh && temperature > tooLow)
                Console.WriteLine("Feeling good!");
            else
                Console.WriteLine("Uh-oh -- better see a doctor!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CheckTemperature(101.3);

            CheckTemperature(101.3, 102.5, 100.5);

            CheckTemperature(96.2, tooLow: 95.5);
        }
    }
}
