using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//使用属性封装
namespace Farmer
{
    class Farmer
    {
        //编译器自动为这个自动属性添加一个私有字段
        public int BagsOfFeed { get; private set; }

        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;
        public int NumberOfCows 
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
    }
}
