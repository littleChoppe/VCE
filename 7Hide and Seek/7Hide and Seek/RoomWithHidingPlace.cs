using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Hide_and_Seek
{
    class RoomWithHidingPlace : Room, IHidingPlace
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

        public RoomWithHidingPlace(string name, string decoration, string hidingPlaceName)
            : base(name, decoration)
        {
            this.hidingPlaceName = hidingPlaceName;
        }
    }
}
