using System;
using System.Collections.Generic;

namespace DataStructuresLibrary.Trees.BinaryTree
{
    public class BinaryTree
    {
        private Node root;
        public Node Root { get => root; private set => root = value; }

        public BinaryTree()
        {
            root = null;
        }
        public BinaryTree(int data)
        {
            root = new Node(data);
        }
        //Print Nodes In-order Traversal
        public void Print()
        {
            PrintInOrder(root);
        }
        //Depth-First Search/Traversal
        private void PrintInOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
                return;
            }
            if (root.left != null)
            {
                PrintInOrder(root.left);
            }
            Console.WriteLine(root.Data);
            if (root.right != null)
            {
                PrintInOrder(root.right);
            }
        }
        //Print Nodes Pre-order Traversal
        private void PrintPreOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
            }
            Console.WriteLine(root.Data);
            if (root.left != null)
            {
                PrintPreOrder(root.left);
            }
            if (root.right != null)
            {
                PrintPreOrder(root.right);
            }
        }
        //Print Nodes Post-order Traversal
        private void PrintPostOrder(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("Tree is empty!");
            }
            if (root.left != null)
            {
                PrintPostOrder(root.left);
            }
            if (root.right != null)
            {
                PrintPostOrder(root.right);
            }
            Console.WriteLine(root.Data);
        }

        //Breadth-First Search using Queue data structure.
        public void PrintByLevel()
        {
            if(root == null)
            {
                throw new BinaryTreeCustomExceptions.TreeIsEmptyException("Tree is empty.");
            }
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            Node rootNode;
            while (queue.Count != 0)
            {
                Console.WriteLine(queue.Peek().Data);
                rootNode = queue.Dequeue();
                if (rootNode.left != null)
                {
                    queue.Enqueue(rootNode.left);
                }
                if (rootNode.right != null)
                {
                    queue.Enqueue(rootNode.right);
                }
            }
        }
        //Insert node into Binary Search tree, note that there can be no duplicate nodes.
        public void Insert(Node newNode)
        {
            InsertInOrder(root, newNode);
        }
        private void InsertInOrder(Node root, Node newNode)
        {
            if (this.root == null)
            {
                this.root = newNode;
                return;
            }
            else if (root.Data == newNode.Data)
            {
                return;
            }

            if (newNode.Data > root.Data)
            {
                if (root.right != null)
                {
                    InsertInOrder(root.right, newNode);
                }
                else
                {
                    root.right = newNode;
                    return;
                }
            }
            else if (newNode.Data < root.Data)
            {
                if (root.left != null)
                {
                    InsertInOrder(root.left, newNode);
                }
                else
                {
                    root.left = newNode;
                    return;
                }
            }
        }
        //Sum all nodes in-order.
        public int Sum()
        {
            return Sum(root);
        }
        private int Sum(Node root)
        {
            int sum = 0;
            if (root == null)
            {
                throw new BinaryTreeCustomExceptions.TreeIsEmptyException("Tree is empty.");
            }
            if (root.left != null)
            {
                sum += Sum(root.left);
            }
            sum += root.Data;
            if (root.right != null)
            {
                sum += Sum(root.right);
            }
            return sum;
        }
        public void Delete(int value)
        {
            Delete(root, value);
        }
        private void Delete(Node root, int value)
        {
            if (value == root.Data)
            {
                DeleteHelper(ref this.root);
                return;
            }
            if (value > root.Data)
            {
                if (value == root.right.Data)
                {
                    //DeleteHelper actually deletes the node and merges the left and right links.
                    DeleteHelper(ref root.right);
                }
                else
                {
                    Delete(root.right, value);
                }
            }
            else if (value < root.Data)
            {
                if (value < root.left.Data)
                {
                    DeleteHelper(ref root.left);
                }
                else
                {
                    Delete(root.left, value);
                }
            }
        }
        private void DeleteHelper(ref Node nodeToDelete)
        {
            //Operations to do whether the node is a leaf, or internal node.
            if (nodeToDelete.left == null && nodeToDelete.right == null)
            {
                nodeToDelete = null;
                return;
            }
            else if (nodeToDelete.left == null)
            {
                nodeToDelete = nodeToDelete.right;
                return;
            }
            else if (nodeToDelete.right == null)
            {
                nodeToDelete = nodeToDelete.left;
                return;
            }
            else
            {
                Node left = nodeToDelete.left;
                Node right = nodeToDelete.right;
                if (nodeToDelete.left.right != null)
                {
                    /*FindLargestNode is a helper method to find the largest node in left subtree to swap with.
                     FindLargestNode.right is the last && largest node.
                     */
                    Node nodeToSwapWith = FindLargestNode(nodeToDelete.left);
                    nodeToDelete = nodeToSwapWith.right;
                    nodeToSwapWith.right = null;
                    nodeToDelete.left = left;
                    nodeToDelete.right = right;
                    return;
                }
                else
                {
                    nodeToDelete = nodeToDelete.left;
                    nodeToDelete.right = right;
                    return;
                }
            }
        }
        private Node FindLargestNode(Node node)
        {
            while (node.right.right != null)
            {
                node = node.right;
            }
            return node;
        }
    }
}