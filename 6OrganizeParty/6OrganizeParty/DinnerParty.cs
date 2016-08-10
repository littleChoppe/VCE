using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//封装,使用属性
namespace _6OrganizeParty
{
    class DinnerParty : Party
    {
        private decimal CostOfBeveragesPerson;

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
        }

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
            }
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

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = base.CalculateCost() + (CostOfBeveragesPerson * NumberOfPeople);
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
