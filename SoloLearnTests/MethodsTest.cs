using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoloLearn;

namespace SoloLearnTests
{
    [TestClass]
    public class MethodsTest
    {
        [TestMethod]
        public void PointsTest()
        {
            int case1 = 4;
            int case2 = 2;
            int case3 = 10;
            int expected1 = 10;
            int expected2 = 3;
            int expected3 = 55;

            int actual1 = Methods.Points(case1);
            int actual2 = Methods.Points(case2);
            int actual3 = Methods.Points(case3);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
