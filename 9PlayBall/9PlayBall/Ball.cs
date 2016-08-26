using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayBall
{
    class Ball
    {
        public event EventHandler<BallEventArgs> BallInPlay;

        protected void OnBallInPlay(BallEventArgs e)
        {
            EventHandler<BallEventArgs> ballInPlay = BallInPlay;
            if (ballInPlay != null)
                ballInPlay(this, e);
        }

        public Bat GetNewBat()
        {
            return new Bat(new BatCallBack(OnBallInPlay));
        }
    }
}
