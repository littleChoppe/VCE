using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6OrganizeParty
{
    public class Party
    {
        private const int CostOfFoodPerPerson = 25;

        private int numberOfPeople;
        private bool fancyDecorations;

        public decimal CostOfDecorations = 0;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            this.NumberOfPeople = numberOfPeople;
//            CalculateCostOfDecorations(fancyDecorations);
        }

        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + CostOfFoodPerPerson * NumberOfPeople;
            if (NumberOfPeople > 12)
            {
                totalCost += 100M;
            }
            return totalCost;
        }
    }
}
