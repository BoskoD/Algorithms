using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class ConvertStringToMilitaryTime
    {
        [TestMethod]
        public void ConvertStringInput_ToMilitaryTime_Returns_CorrectValue()
        {
            //Arrange
            string expected = "19:05:45";
            string str = "07:05:45PM";

            //Act
            TimeConversion.Result.ConvertTimeToMilitary(str);

            //Assert
            string actual = TimeConversion.Result.ConvertTimeToMilitary(str);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ConvertStringInput_ToMilitaryTime_BadInput()
        {
            //Arrange
            string expected = "Bad input";
            string str = "19:05:45 UTC";

            //Act
            TimeConversion.Result.ConvertTimeToMilitary(str);

            //Assert
            string actual = TimeConversion.Result.ConvertTimeToMilitary(str);
            Assert.AreEqual(expected, actual);
        }
    }
}