using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class HowManyWordsInAString
    {
        [TestMethod]
        public void HowManyWords_InputHas3_Words_Returns3_Correct()
        {
            //Arrange
            int expected = 3;
            string str = "oneTwoThree";

            //Act
            CamelCase.Result.CamelCase(str);

            //Assert
            int actual = CamelCase.Result.CamelCase(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HowManyWords_InputHas5_Words_Returns5_Correct()
        {
            //Arrange
            int expected = 5;
            string str = "oneTwoThreeFourFive";

            //Act
            CamelCase.Result.CamelCase(str);

            //Assert
            int actual = CamelCase.Result.CamelCase(str);
            Assert.AreEqual(expected, actual);
        }
    }
}