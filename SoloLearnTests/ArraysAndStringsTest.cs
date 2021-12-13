using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoloLearn;
using System.Collections.Generic;

namespace SoloLearnTests
{
    [TestClass]
    public class ArraysAndStringsTest
    {
        [TestMethod]
        public void SortTest()
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };
            string case1 = "l";
            string case2 = "z";
            string case3 = "a";
            List<string> expected1 = new List<string>
            {
                "football",
                "learn"
            };
            List<string> expected2 = new List<string>
            {
                "No match"
            };
            List<string> expected3 = new List<string>
            {
                "programming",
                "football",
                "learn",
                "dream"
            };

            var actual1 = ArraysAndStrings.Sort(words, case1);
            var actual2 = ArraysAndStrings.Sort(words, case2);
            var actual3 = ArraysAndStrings.Sort(words, case3);

            Assert.AreEqual(expected1.ToArray()[0], actual1.ToArray()[0]);
            Assert.AreEqual(expected1.ToArray()[1], actual1.ToArray()[1]);
            Assert.AreEqual(expected1.ToArray().Length, actual1.ToArray().Length);

            Assert.AreEqual(expected2.ToArray()[0], actual2.ToArray()[0]);
            Assert.AreEqual(expected2.ToArray().Length, actual2.ToArray().Length);

            Assert.AreEqual(expected3.ToArray()[0], actual3.ToArray()[0]);
            Assert.AreEqual(expected3.ToArray()[1], actual3.ToArray()[1]);
            Assert.AreEqual(expected3.ToArray()[2], actual3.ToArray()[2]);
            Assert.AreEqual(expected3.ToArray().Length, actual3.ToArray().Length);


        }
    }
}
