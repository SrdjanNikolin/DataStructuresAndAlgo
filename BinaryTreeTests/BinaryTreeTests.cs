using NUnit.Framework;
using DataStructuresLibrary.Trees.BinaryTree;

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
        public void BinaryTreeDeleteTEst()
        {
            BinaryTree tree = new BinaryTree(11);
            tree.InsertInOrder(tree.Root, new Node(6));
            tree.InsertInOrder(tree.Root, new Node(8));
            tree.InsertInOrder(tree.Root, new Node(19));
            tree.InsertInOrder(tree.Root, new Node(4));
            tree.InsertInOrder(tree.Root, new Node(10));
            tree.InsertInOrder(tree.Root, new Node(5));
            tree.InsertInOrder(tree.Root, new Node(17));
            tree.InsertInOrder(tree.Root, new Node(43));
            tree.InsertInOrder(tree.Root, new Node(49));
            tree.InsertInOrder(tree.Root, new Node(31));
            tree.Delete(tree.Root, 49);
            Assert.IsNull(tree.Root.right.right.right);
        }
        [Test]
        public void BinaryTreeSum()
        {
            BinaryTree tree = new BinaryTree(11);
            tree.InsertInOrder(tree.Root, new Node(6));
            tree.InsertInOrder(tree.Root, new Node(8));
            tree.InsertInOrder(tree.Root, new Node(19));
            tree.InsertInOrder(tree.Root, new Node(4));
            tree.InsertInOrder(tree.Root, new Node(10));
            tree.InsertInOrder(tree.Root, new Node(5));
            tree.InsertInOrder(tree.Root, new Node(17));
            tree.InsertInOrder(tree.Root, new Node(43));
            tree.InsertInOrder(tree.Root, new Node(49));
            tree.InsertInOrder(tree.Root, new Node(31));
            int sum = tree.Sum(tree.Root);
            Assert.AreEqual(203, sum);
        }
    }
}