using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Party
{
    class BirthdayParty
    {
        private const int CostOfFoodPerPerson = 25;

        private int numberOfPeople;
        private bool fancyDecorations;
        private string cakeWriting = "";

        private decimal CostOfDecorations = 0;
        private int CakeSize;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
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

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

        public decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + CostOfFoodPerPerson * NumberOfPeople;
            decimal cakeCost;
            if (CakeSize == 8)
                cakeCost = 40M + CakeWriting.Length * .25M;
            else
                cakeCost = 75M + CakeWriting.Length * .25M;
            return totalCost + cakeCost;
        }
    }
}
