using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6OverrideAndNew
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        //此处如果在子类中不写任何东西直接重写方法会引起警告相当于在方法上写new关键字，只能起隐藏方法的作用
        public void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
    }
}
