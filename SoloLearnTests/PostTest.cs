using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SoloLearn;

namespace SoloLearnTests
{
    [TestClass]
    public class PostTest
    {
        [TestMethod]
        public void ShowPostTest()
        {
            string case1 = "Hello!";
            string case2 = "What a good day!";
            string case3 = "Graduated!";
            string newpost = "New post";
            string expected1 = newpost + System.Environment.NewLine + "Hello!";
            string expected2 = newpost + System.Environment.NewLine + "What a good day!";
            string expected3 = newpost + System.Environment.NewLine + "Graduated!";
            Post post1 = new Post();
            Post post2 = new Post();
            Post post3 = new Post();

            post1.Text = case1;
            post2.Text = case2;
            post3.Text = case3;
            var actual1 = post1.Text;
            var actual2 = post2.Text;
            var actual3 = post3.Text;

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);

        }
    }
}
