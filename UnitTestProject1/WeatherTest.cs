using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand;

namespace LemonadeStandTest
{
    [TestClass]
    public class WeatherTest
    {
        Random rng = new Random();
        [TestMethod]
        public void Weather_WithinRangeIndex_SetsCondition()
        {
            Weather w = new Weather(rng);
        }
    }
}
