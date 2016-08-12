using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Hide_and_Seek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        private string hidingPlaceName;
        public string HidingPlaceName
        {
            get { return hidingPlaceName; }
        }

        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + hidingPlaceName + ".";
            }
        }

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlaceName)
            : base(name, hot)
        {
            this.hidingPlaceName = hidingPlaceName;
        }
    }
}
