using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//强制类型转换时，实际上是正在向编译器做出一个承诺，
//表明你知道它们的类型不一样，但在这个特定情况下C#确实可以把数据填到新变量里。
namespace Chapter3Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal myDecimalValue = 10;
            int myIntValue = (int)myDecimalValue;
            MessageBox.Show("The myIntValue is " + myIntValue);
        }
    }
}
