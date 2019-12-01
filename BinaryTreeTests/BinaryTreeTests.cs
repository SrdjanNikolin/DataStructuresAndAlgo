using NUnit.Framework;
using DataStructuresLibrary.Trees.BinaryTree;

namespace BinaryTreeTests
{
    public class Tests
    {
        [Test]
        public void BinaryTreeCreationTest()
        {
            BinaryTree myTree = new BinaryTree(5);
            Assert.AreEqual(5, myTree.Root.Data);
        }
    }
}