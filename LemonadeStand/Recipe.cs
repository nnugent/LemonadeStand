using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Recipe
    {
        private int numberOfLemons;
        private int cupsOfSugar;
        private int numberOfIceCubes;

        public int NumberOfLemons
        {
            get
            {
                return numberOfLemons;
            }
            set
            {
                numberOfLemons = value;
            }
        }

        public int CupsOfSugar
        {
            get
            {
                return cupsOfSugar;
            }
            set
            {
                cupsOfSugar = value;
            }
        }

        public int NumberOfIceCubes
        {
            get
            {
                return numberOfIceCubes;
            }
            set
            {
                numberOfIceCubes = value;
            }
        }
    }
}
