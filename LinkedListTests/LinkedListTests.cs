using NUnit.Framework;

namespace LinkedListTests
{
    public class LinkedListTests
    {
        [Test]
        public void PushDataAtEndOfList()
        {
            //Arrange
            LinkedList myList = new LinkedList();
            //Act
            myList.PushAtEnd(5);
            myList.PushAtEnd(10);
            myList.PushAtEnd(15);
            myList.PushAtEnd(20);
            //Return sum of all data
            int sum = myList.GetSumOfAllData();

            //Assert
            Assert.AreEqual(50, sum);
        }
        [Test]
        public void PushDataAtStartOfList()
        {
            //Arrange
            LinkedList myList = new LinkedList();
            //Act
            myList.PushAtStart(5);
            myList.PushAtStart(5);
            myList.PushAtStart(5);
            int sum = myList.GetSumOfAllData();
            Assert.AreEqual(15, sum);
        }
        [Test]
        public void PushDataAfterGivenNode()
        {
            LinkedList myList = new LinkedList();
            myList.PushAtEnd(5);
            myList.PushAtEnd(10);
            myList.PushAtEnd(15);
            myList.PushAtEnd(25);
            Node givenNode = myList.Head.Next.Next;
            myList.PushAfterNode(givenNode, 20);
            int sum = myList.GetSumOfAllData();
            Assert.AreEqual(75, sum);
        }
        [Test]
        public void PeekLastElementOfList()
        {
            LinkedList myList = new LinkedList();
            myList.PushAtEnd(5);
            myList.PushAtEnd(10);
            myList.PushAtEnd(15);
            int peekLastElement = myList.PeekLast();
            Assert.AreEqual(15, peekLastElement);
        }
        [Test]
        public void PrintAllDataWhenListIsEmptyException()
        {
            //Arrange
            LinkedList myList = new LinkedList();
            //Assert
            Assert.Throws<LinkedListCustomExceptions.ListIsEmptyException>(() => myList.PrintAllData());
        }
        [Test]
        public void CountAllNodesIfListNotEmpty()
        {
            LinkedList myList = new LinkedList();
            myList.PushAtEnd(5);
            myList.PushAtEnd(10);
            myList.PushAtEnd(15);
            myList.PushAtEnd(20);
            myList.PushAtStart(30);
            int count = myList.Count(); //return n of nodes
            Assert.AreEqual(5, count);
        }
        [Test]
        public void CountAllNodesIfListEmpty()
        {
            LinkedList myList = new LinkedList();
            int count = myList.Count();
            Assert.AreEqual(0, count);
        }
        [Test]
        public void DeleteFirstOccurenceOfNodeWithGivenValue()
        {
            LinkedList myList = new LinkedList();
            myList.PushAtEnd(5);
            myList.PushAtEnd(10);
            myList.PushAtEnd(15);
            myList.PushAtEnd(20);
            myList.DeleteNode(15);
            int sum = myList.GetSumOfAllData();
            Assert.AreEqual(35, sum);
        }
        [Test]
        public void DeleteNodeAtGivenPosition()
        {
            LinkedList myList = new LinkedList();
            myList.PushAtEnd(5);
            myList.PushAtEnd(10);
            myList.PushAtEnd(15);
            myList.PushAtEnd(20);
            myList.DeleteNodeAtPosition(2);
            int sum = myList.GetSumOfAllData();
            Assert.AreEqual(35, sum);
        }
    }
}