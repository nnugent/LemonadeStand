using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class BusinessPerson : Customer
    {
        public BusinessPerson()
        {
            prefferedRecipe.NumberOfLemons = 4;
            prefferedRecipe.CupsOfSugar = 5;
            prefferedRecipe.NumberOfIceCubes = 5;
        }
    }
}
