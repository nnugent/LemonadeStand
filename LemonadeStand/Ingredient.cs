using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    abstract class Ingredient
    {
        protected int parishTime;
        protected double unitPrice;
        protected double parishChance;
        protected int daysOld;

        public Ingredient()
        {

        }

        abstract public void GetParishChance();

        public int ParishRate
        {
            get
            {
                return parishTime;
            }
        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
        }

        public double ParishChance
        {
            get
            {
                return parishChance/100;
            }
        }
        
        public int DaysOld
        {
            get
            {
                return daysOld;
            }
            set
            {
                daysOld = value;
            }
        }
    }
}

