using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _7InterfaceProgramme3
{
    internal class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
//        private string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public string FunnyThingIHave
        {
            get { return "Honk honk! I have " + funnyThingIHave; }
        }

        public void Honk()
        {
            MessageBox.Show(this.FunnyThingIHave);
        }
    }
}
