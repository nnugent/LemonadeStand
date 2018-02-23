using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Ice : Ingredient
    {
        public Ice()
        {
            unitPrice = .005;
            parishTime = 1;
        }
        public override void GetParishChance()
        {
            parishChance = 100;
        }
    }
}
