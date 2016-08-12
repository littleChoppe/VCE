using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Programme1
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get; private set; }
        public int StingerLength { get; set; }
        public bool LookForEnemies()
        {
            return false;
        }
        public int SharpenStinger(int length)
        {
            return 0;
        }
    }
}
