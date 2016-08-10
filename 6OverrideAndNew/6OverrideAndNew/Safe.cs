using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6OverrideAndNew
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "123456";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
                return contents;
            else
                return null;
        }
        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
