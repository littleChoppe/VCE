using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7InterfaceProgramme3
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChildren();
    }
}
