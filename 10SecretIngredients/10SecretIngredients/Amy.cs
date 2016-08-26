using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecretIngredients
{
    class Amy
    {
        public GetSecretIngredient MySecretIngredientMethod
        {
            get
            {
                return new GetSecretIngredient(AmysSecretIngredient);
            }
        }

        private string AmysSecretIngredient(int amount)
        {
            if (amount < 10)
                return amount.ToString() + " cans of sardines -- you need more!";
            else
                return amount.ToString() + " cans of sardines";
        }
    }
}
