using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Student : Customer
    {
        public Student()
        {
            prefferedRecipe.NumberOfLemons = 6;
            prefferedRecipe.CupsOfSugar = 4;
            prefferedRecipe.NumberOfIceCubes = 3;
            budget = 2;
        }
    }
}
