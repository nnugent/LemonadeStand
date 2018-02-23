using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Cup : Ingredient
    {
        public Cup()
        {
            unitPrice = .05;
            parishTime = 100;
            daysOld = 1;
        }

        public override void GetParishChance()
        {
            parishChance = 0;
        }
    }
}
