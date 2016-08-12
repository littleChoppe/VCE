using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7Hide_and_Seek
{
    abstract class Location
    {
        private string name;
        public Location[] Exits;

        public Location(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public virtual string Description
        {
            get
            {
                string description = "You're standing in the " + name +
                    ". You see exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].name;
                    if (i != Exits.Length - 1)
                        description += ",";
                }
                description += ".";
                return description;
            }
        }
    }
}
