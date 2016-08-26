using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SecretIngredients
{
    public partial class Form1 : Form
    {
        GetSecretIngredient ingredientMothod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();

        public Form1()
        {
            InitializeComponent();
        }

        private void useIngredient_Click(object sender, EventArgs e)
        {
            if (ingredientMothod != null)
                Console.WriteLine("I'll add " + ingredientMothod((int)amount.Value));
            else
                Console.WriteLine("I don't have a secret ingredient!");
        }

        private void getSuzanne_Click(object sender, EventArgs e)
        {
            ingredientMothod = new GetSecretIngredient(suzanne.MySecretIngredientMethod);
        }

        private void getAmy_Click(object sender, EventArgs e)
        {
            ingredientMothod = new GetSecretIngredient(amy.MySecretIngredientMethod);
        }
    }
}
