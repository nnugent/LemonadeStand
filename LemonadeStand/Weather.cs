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
            getTemperature(rng);
            getWeatherClarity(rng);
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

        private void getTemperature(Random rng)
        {
            temperature = rng.Next(100);
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
