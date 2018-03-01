using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStandTest;

namespace LemonadeStandTest
{
    [TestClass]
    public class WeatherTest
    {
        Random rng = new Randon();
        [TestMethod]
        public void Weather_WithinRangeIndex_SetsCondition()
        {
            Weather w = new Weather(rng);
            w.GetTemperature(rng.Next());
        }
    }
}
