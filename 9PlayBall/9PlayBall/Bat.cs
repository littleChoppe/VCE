using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayBall
{
    delegate void BatCallBack(BallEventArgs e);

    class Bat
    {
        private BatCallBack hitBallCallBack;

        public Bat(BatCallBack callbackDelegate)
        {
            this.hitBallCallBack = new BatCallBack(callbackDelegate);
        }

        public void HitTheBall(BallEventArgs e)
        {
            if (hitBallCallBack != null)
                hitBallCallBack(e);
        }
    }
}
