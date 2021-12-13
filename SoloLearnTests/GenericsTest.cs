using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoloLearn;
using System.Collections.Generic;

namespace SoloLearnTests
{
    [TestClass]
    public class GenericsTest
    {
        [TestMethod]
        public void DiscountTest()
        {
            Dictionary<string, int> coffee = new Dictionary<string, int>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            double discount = 10;
            List<string> expected = new List<string>()
                        {
                        "Americano: 45",
                        "Latte: 63",
                        "Flat White: 54",
                        "Espresso: 54",
                        "Cappuccino: 72",
                        "Mocha: 81"
                         };

            List<string> actual = Generics.Discount(coffee, discount);

            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
            Assert.AreEqual(expected[3], actual[3]);
            Assert.AreEqual(expected[4], actual[4]);
            Assert.AreEqual(expected[5], actual[5]);


        }
    }
}
