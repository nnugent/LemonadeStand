using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Lemon : Ingredient
    {
        public Lemon()
        {
            unitPrice = .40;
            parishTime = 4;
            daysOld = 1;
        }
        public override void GetParishChance()
        {
            throw new NotImplementedException();
        }
    }
}
