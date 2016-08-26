using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//事件
namespace PlayBall
{
    public partial class Form1 : Form
    {
        Ball ball = new Ball();
        Pitcher pitcher;
        Fan fan;

        public Form1()
        {
            InitializeComponent();
            pitcher = new Pitcher(ball);
            fan = new Fan(ball);
        }

        private void playBall_Click(object sender, EventArgs e)
        {
            BallEventArgs ballEventArgs = new BallEventArgs((int)trajectory.Value, (int)distance.Value);
            Bat bat = ball.GetNewBat();
            bat.HitTheBall(ballEventArgs);
        }


    }
}
