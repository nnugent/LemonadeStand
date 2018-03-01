using System;
using System.Collections.Generic;
using System.Text;

namespace LemonadeStand
{
    class Weather
    {
        private int temperature;
        private string condition;
        private List<string> weatherConditions = new List<string>() { "Sunny", "Cloudy", "Overcast", "Rainy", "Fog" };

        public Weather(Random rng)
        {
            getTemperature(rng.Next(100));
            getWeatherClarity(rng.Next(5));
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
        }

        public string Condition
        {
            get
            {
                return condition;
            }
        }

        private void getTemperature(int value)
        {
            temperature = value;
        }

        private void getWeatherClarity(int indexValue)
        {
            condition = weatherConditions[indexValue];
            if(temperature < 32 && condition == "Rain")
            {
                condition = "Snow";
            }
        }
    }
    
}
