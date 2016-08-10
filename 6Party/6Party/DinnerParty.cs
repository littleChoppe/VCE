using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//封装,使用属性
namespace Party
{
    class DinnerParty
    {
        private int numberOfPeople;
        private bool fancyDecorations;

        private decimal CostOfBeveragesPerson;
        private decimal CostOfDecorations = 0;

        private const int CostOfFoodPerPerson = 25;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(this.fancyDecorations);
            }
        }

        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancyOption)
        {
            if (fancyOption)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerson + CostOfFoodPerPerson) * numberOfPeople);
            if (healthyOption)
            {
                return totalCost * .95M;
            }
            else 
            {
                return totalCost;
            }
        }
    }
}
