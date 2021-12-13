using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoloLearn;
using System;

namespace SoloLearnTests
{
    [TestClass]
    public class ConditionalsAndLoopsTest
    {
        [TestMethod]
        public void MultiplesTest()
        {
            int multiple = 3;
            int casenumber1 = 7;
            int casenumber2 = 10;
            int casenumber3 = 15;
            string expected1 = "1, 2, *, 4, 5, *, 7, ";
            string expected2 = "1, 2, *, 4, 5, *, 7, 8, *, 10, ";
            string expected3 = "1, 2, *, 4, 5, *, 7, 8, *, 10, 11, *, 13, 14, *, ";

            string actual1 = ConditionalsAndLoops.Multiples(casenumber1, multiple);
            string actual2 = ConditionalsAndLoops.Multiples(casenumber2, multiple);
            string actual3 = ConditionalsAndLoops.Multiples(casenumber3, multiple);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
