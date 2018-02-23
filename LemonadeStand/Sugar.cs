using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Sugar : Ingredient
    {
        public Sugar()
        {
            unitPrice = .70;
            parishTime = 7;
            daysOld = 1;
        }

        public override void GetParishChance()
        {
            if (parishTime > daysOld)
            {
                parishChance += 30;
            }
            else
            {
                parishChance = 2;
            }
        }
    }
}
