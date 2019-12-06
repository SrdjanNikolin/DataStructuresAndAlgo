using System;

namespace DataStructuresLibrary.Trees.BinaryTree
{
    public class BinaryTree
    {
        public Node Root { get; private set; }
        public BinaryTree()
        {
            Root = null;
        }
        public BinaryTree(int data)
        {
            Root = new Node(data);
        }
        //Print Nodes In-order Traversal
        public void PrintInOrder(Node root)
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
        public void PrintPreOrder(Node root)
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
        public void PrintPostOrder(Node root)
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
        //Insert node into Binary Search tree, note that there can be no duplicate nodes.
        public void InsertInOrder(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
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
        public void DeleteNode(ref Node root, int value)
        {
            if (root.Data == value)
            {
                if (root.left == null && root.right == null)
                {
                    root = null;
                    return;
                }
                else if (root.left == null)
                {
                    root = root.right;
                    return;
                }
                else if (root.right == null)
                {
                    root = root.left;
                    return;
                }
                else
                {
                    Node inOrderPredeccessor = root.left;
                    while (inOrderPredeccessor.right != null)
                    {
                        inOrderPredeccessor = inOrderPredeccessor.right;
                    }
                    root = inOrderPredeccessor;
                    inOrderPredeccessor = null;
                    return;
                }
            }
            else
            {
                if (value > root.Data)
                {
                    DeleteNode(ref root.right, value);
                    return;
                }
                else if (value < root.Data)
                {
                    DeleteNode(ref root.left, value);
                    return;
                }
            }
        }
    }
}