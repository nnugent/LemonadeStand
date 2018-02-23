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
        }
        public override void GetParishChance()
        {
            parishChance = 2;
        }
    }
}
