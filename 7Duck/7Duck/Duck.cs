using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//使用IComparable<Duck>
namespace _7Duck
{
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }

    class Duck : IComparable<Duck>
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
    }
}
