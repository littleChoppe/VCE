using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//父类的构造函数会在子类的构造函数前运行
namespace InheritConstructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MyBaseClass("baseclass!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MySubClass("subclass to baseclass", 2);
        }
    }
}
