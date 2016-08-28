using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Out
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        public int ReturnThreeValues(out double half, out int twice)
        {
            int value = random.Next(100);
            half = ((double)value) / 2;
            twice = value * 2;
            return value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            double b;
            int c;
            a = ReturnThreeValues(out b, out c);
            Console.WriteLine("value = {0}, half = {1}, double = {2}", a, b, c);
        }
    }
}
