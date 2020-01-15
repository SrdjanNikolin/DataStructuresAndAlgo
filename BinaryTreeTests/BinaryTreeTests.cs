using DataStructuresLibrary.Trees.BinaryTree;
using NUnit.Framework;
using static DataStructuresLibrary.Trees.BinaryTreeCustomExceptions;

namespace BinaryTreeTests
{
    public class Tests
    {
        //Write Method and Test to summ all nodes, it will make it easier to test deletion and insertion.
        [Test]
        public void BinaryTreeCreationTest()
        {
            BinaryTree myTree = new BinaryTree(5);
            Assert.AreEqual(5, myTree.Root.Data);
        }
        [Test]
        public void BinaryTreeDeleteTest()
        {
            BinaryTree tree = new BinaryTree(11);
            tree.Insert(new Node(6));
            tree.Insert(new Node(8));
            tree.Insert(new Node(19));
            tree.Insert(new Node(4));
            tree.Insert(new Node(10));
            tree.Insert(new Node(5));
            tree.Insert(new Node(17));
            tree.Insert(new Node(43));
            tree.Insert(new Node(49));
            tree.Insert(new Node(31));
            tree.Delete(49);
            int sum = tree.Sum();
            Assert.IsNull(tree.Root.right.right.right);
            Assert.AreEqual(154, sum);
        }
        [Test]
        public void BinaryTreeDeleteRootNode()
        {
            BinaryTree tree = new BinaryTree(11);
            tree.Insert(new Node(6));
            tree.Insert(new Node(8));
            tree.Insert(new Node(19));
            tree.Insert(new Node(4));
            tree.Insert(new Node(10));
            tree.Insert(new Node(5));
            tree.Insert(new Node(17));
            tree.Insert(new Node(43));
            tree.Insert(new Node(49));
            tree.Insert(new Node(31));
            tree.Delete(11);
            int rootData = tree.Root.Data;
            int sum = tree.Sum();
            Assert.AreEqual(192, sum);
            Assert.AreEqual(10, rootData);
        }
        [Test]
        public void BinaryTreeSum()
        {
            BinaryTree tree = new BinaryTree(11);
            tree.Insert(new Node(6));
            tree.Insert(new Node(8));
            tree.Insert(new Node(19));
            tree.Insert(new Node(4));
            tree.Insert(new Node(10));
            tree.Insert(new Node(5));
            tree.Insert(new Node(17));
            tree.Insert(new Node(43));
            tree.Insert(new Node(49));
            tree.Insert(new Node(31));
            int sum = tree.Sum();
            Assert.AreEqual(203, sum);
        }
        [Test]
        public void BinaryTreeFind()
        {
            BinaryTree tree = new BinaryTree(11);
            tree.Insert(new Node(6));
            tree.Insert(new Node(8));
            tree.Insert(new Node(19));
            tree.Insert(new Node(4));
            tree.Insert(new Node(10));
            tree.Insert(new Node(5));
            tree.Insert(new Node(17));
            tree.Insert(new Node(43));
            tree.Insert(new Node(49));
            tree.Insert(new Node(31));
            int findValue = tree.Find(49);
            Assert.AreEqual(49, findValue);
            Assert.Throws<ValueNotFoundException>(() => tree.Find(100));
        }
    }
}