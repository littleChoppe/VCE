using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//使用单独的类来实现排序的好处是可以有多种排序方式以及更复杂的排序方式
//注意使用的是IComparer而不是IComparable
namespace _7SortDuck
{
    class DuckCompareByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind < y.Kind)
                return -1;
            if (x.Kind > y.Kind)
                return 1;
            else
                return 0;
        }
    }
}
