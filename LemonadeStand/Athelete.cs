using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Athelete : Customer
    {
        public Athelete()
        {
            prefferedRecipe.NumberOfLemons = 6;
            prefferedRecipe.CupsOfSugar = 2;
            prefferedRecipe.NumberOfIceCubes = 2;
            budget = 2.50;
        }
    }
}
