using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoloLearn;

namespace SoloLearnTests
{
    [TestClass]
    public class MoreOnClassesTest
    {
        [TestMethod]
        public void DancerPointsTest()
        {
            string name1 = "Tom";
            int points1 = 5;
            string name2 = "Lilith";
            int points2 = 6;
            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);
            string expectedname = "Tom & Lilith";
            int expectedpoints = 11;

            DancerPoints total = dancer1 + dancer2;

            Assert.AreEqual(expectedname, total.name);
            Assert.AreEqual(expectedpoints, total.points);

        }
    }
}
