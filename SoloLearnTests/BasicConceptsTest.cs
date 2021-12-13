using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoloLearn;

namespace SoloLearnTests
{
    [TestClass]
    public class BasicConceptsTest
    {
        [TestMethod]
        public void AreaOfCircleTest()
        {
            double pi = 3.14;
            double case1 = 5;
            double case2 = 6.4;
            double case3 = 10;
            double expected1 = 78.5;
            double expected2 = 128.6144;
            double expected3 = 314;
            double delta = 0.00001;

            double actual1 = BasicConcepts.AreaOfCircle(case1, pi);
            double actual2 = BasicConcepts.AreaOfCircle(case2, pi);
            double actual3 = BasicConcepts.AreaOfCircle(case3, pi);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2, delta);
            Assert.AreEqual(expected3, actual3);

        }
    }
}
