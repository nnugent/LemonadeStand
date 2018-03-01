using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Child : Customer
    {
        public Child()
        {
            prefferedRecipe.NumberOfLemons = 3;
            prefferedRecipe.CupsOfSugar = 6;
            prefferedRecipe.NumberOfIceCubes = 4;
            budget = 1.50;
        }
    }
}
