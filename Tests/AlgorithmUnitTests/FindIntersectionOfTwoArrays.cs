using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class FindIntersectionOfTwoArrays
    {
        [TestMethod]
        public void IntersectionOfTwoArrays_Returns_Correct()
        {
            //Arrange
            int[] arr1 = new int[] { 1, 2, 3, 7, 8 };
            int[] arr2 = new int[] { 2, 7, 9, 9, 0 };
            int[] expected = new int[] { 2, 7 };

            //Act
            IntersectionOfTwoArrays.Result.FindIntersection(arr1, arr2);

            //Assert
            var actual = IntersectionOfTwoArrays.Result.FindIntersection(arr1, arr2);
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.IsTrue((expected[0] == actual[0]) && (expected[^1] == actual[^1]));
        }
    }
}