﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//使用IComparable<Duck>
namespace _7DuckToBird
{
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }

    class Duck : Bird,IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size)
                return 1;
            else if (this.Size < duckToCompare.Size)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return "A " + Size + " inch " + Kind;
        }
    }
}
