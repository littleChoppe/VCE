using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elephant
{
    public partial class Form1 : Form
    {
        Elephant lloyd;
        Elephant lucinda;

        public Form1()
        {
            InitializeComponent();
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Elephant holder;
            holder = lloyd;
            lloyd = lucinda;
            lucinda = holder;
            MessageBox.Show("Object swapped");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lloyd.TellMe("Hi", lucinda);
            lloyd.SpeakTo(lucinda, "Hello");
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
