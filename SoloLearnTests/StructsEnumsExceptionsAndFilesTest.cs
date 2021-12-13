using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoloLearn;

namespace SoloLearnTests
{
    [TestClass]
    public class StructsEnumsExceptionsAndFilesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string drinks1 = "30";
            string shelves1 = "3";
            string drinks2 = "5";
            string shelves2 = "0";
            string drinks3 = "six";
            string shelves3 = "3";
            string expected1 = "10";
            string expected2 = "At least 1 shelf";
            string expected3 = "Please insert an integer";

            var actual1 = StructsEnumsExceptionsAndFiles.Main7(drinks1, shelves1);
            var actual2 = StructsEnumsExceptionsAndFiles.Main7(drinks2, shelves2);
            var actual3 = StructsEnumsExceptionsAndFiles.Main7(drinks3, shelves3);

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);




        }
    }
}
