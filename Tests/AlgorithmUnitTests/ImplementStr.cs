//https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/885/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class ImplementStr
    {
        [TestMethod]
        public void FindNeedleInAHaystack_Returns_CorrectIndex()
        {
            //Arrange
            int expected = 2;
            string haystack = "hello";
            string needle = "ll";

            //Act
            ImplementStrStr.Result.StrStr(haystack, needle);

            //Assert
            var actual = ImplementStrStr.Result.StrStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindNeedleInAHaystack_NeedleNotInHaystack_Returns_Minus1()
        {
            //Arrange
            int expected = -1;
            string haystack = "howdy";
            string needle = "ll";

            //Act
            ImplementStrStr.Result.StrStr(haystack, needle);

            //Assert
            var actual = ImplementStrStr.Result.StrStr(haystack, needle);
            Assert.AreEqual(expected, actual);
        }
    }
}