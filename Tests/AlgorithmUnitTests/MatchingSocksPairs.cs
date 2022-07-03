using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class MatchingSocksPairs
    {
        [TestMethod]
        public void CountMatchingSocksPairs_Returns_CorrectValue()
        {
            //Arrange
            int expected = 2;
            
            List<int> list = new List<int> { 1, 1, 2, 3, 4, 4 };
            var arr = list.ToArray();
            var size = arr.Length;

            //Act
            SalesByMatch.Result.SockMerchant(size, arr);

            //Assert
            int actual = SalesByMatch.Result.SockMerchant(size, arr);
            Assert.AreEqual(expected, actual);
        }
    }
}