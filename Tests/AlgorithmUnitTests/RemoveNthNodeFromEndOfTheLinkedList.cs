using Microsoft.VisualStudio.TestTools.UnitTesting;
using RemoveNthNodeFromEndOfList;

namespace AlgorithmUnitTests
{
    [TestClass]
    public class RemoveNthNodeFromEndOfTheLinkedList
    {
        [TestMethod]
        public void RemoveNthNode_Returns_Head_Data()
        {
            //Arrange
            int expected = 1;

            LinkedList list = new LinkedList();
            list.AddAtHead(5);
            list.AddAtHead(4);
            list.AddAtHead(3);
            list.AddAtHead(2);
            list.AddAtHead(1);

            var headNode = list.head;
            var n = 2;

            //Act
            list.RemoveNthFromEnd(headNode, n);

            //Assert
            int actual = list.RemoveNthFromEnd(headNode, n).Data;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveNthNode_SearchForRemovedNode_Returns_Minus1()
        {
            //Arrange
            int expected = -1;

            LinkedList list = new LinkedList();
            list.AddAtHead(5);
            list.AddAtHead(4);
            list.AddAtHead(3);
            list.AddAtHead(2);
            list.AddAtHead(1);

            var headNode = list.head;
            var n = 2;

            //Act
            list.RemoveNthFromEnd(headNode, n);

            //Assert
            int actual = list.SearchValue(4);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveNthNode_SearchForTailIndex_Returns_3()
        {
            //Arrange
            int expected = 3;

            LinkedList list = new LinkedList();
            list.AddAtHead(5);
            list.AddAtHead(4);
            list.AddAtHead(3);
            list.AddAtHead(2);
            list.AddAtHead(1);

            var headNode = list.head;
            var n = 2;

            //Act
            list.RemoveNthFromEnd(headNode, n);

            //Assert
            int actual = list.SearchValue(5);
            Assert.AreEqual(expected, actual);
        }
    }
}