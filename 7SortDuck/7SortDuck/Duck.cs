using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7SortDuck
{
    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }

    class Duck
    {
        public int Size;
        public KindOfDuck Kind;

        /// <summary>
        /// 覆盖基类的ToString方法，使用调试查看效果
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "A " + Size + " inch " + Kind;
        }
    }
}
