﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7Canteen
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        public Form1()
        {
            InitializeComponent();
            RedrawList();
        }

        private void RedrawList()
        {
            int number = 1;
            line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextLine.Text = "";
                nextLumberjack.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextLine.Text = currentLumberjack.Name + " has " +
                    currentLumberjack.FlapjackCount + " flapjacks";
                nextLumberjack.Enabled = true;
            }
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(name.Text));
            name.Text = "";
            RedrawList();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (crispy.Checked)
                food = Flapjack.Crispy;
            else if (soggy.Checked)
                food = Flapjack.Soggy;
            else if (browned.Checked)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);

            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack NextLumberjack = breakfastLine.Dequeue();
            NextLumberjack.EatFlapjacks();
            nextLine.Text = "";
            RedrawList();
        }
    }
}
