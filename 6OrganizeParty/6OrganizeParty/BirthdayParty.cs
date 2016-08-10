using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _6OrganizeParty
{
    class BirthdayParty : Party
    {
        private string cakeWriting = "";
        private int CakeSize;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting) 
            : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
        }

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
            }
        }
        public string CakeWriting
        {
            get { return this.cakeWriting; }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch cake");
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;
            }
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public override decimal CalculateCost()
        {
            decimal cakeCost;
            if (CakeSize == 8)
                cakeCost = 40M + CakeWriting.Length * .25M;
            else
                cakeCost = 75M + CakeWriting.Length * .25M;
            return base.CalculateCost() + cakeCost;
        }
    }
}
