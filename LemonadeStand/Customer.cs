using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    abstract class Customer
    {
        protected double budget;
        protected Recipe prefferedRecipe = new Recipe();
        

        public Customer()
        {

        }

        public double GetPurchaseChance(Recipe currentRecipe)
        {
            if (prefferedRecipe.Equals(currentRecipe))
            {
                return 100;
            }
            else if (prefferedRecipe.NumberOfLemons == currentRecipe.NumberOfLemons || prefferedRecipe.NumberOfIceCubes == currentRecipe.NumberOfIceCubes || prefferedRecipe.CupsOfSugar == currentRecipe.CupsOfSugar)
            {
                return 60;
            }
            else if (prefferedRecipe.NumberOfLemons - currentRecipe.NumberOfLemons <= 2 || prefferedRecipe.NumberOfIceCubes - currentRecipe.NumberOfIceCubes <= 2 || prefferedRecipe.CupsOfSugar - currentRecipe.CupsOfSugar <= 2)
            {
                return 40;
            }
            else
            {
                return 10;
            }
        }
    }
}
