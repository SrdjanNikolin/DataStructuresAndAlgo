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

        public void Insert(int data)
        {
            if (Root == null)
            {
                Root = new Node(data);
                return;
            }
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
        /*Insert Node in Binary Tree, note that this implementation is not good if it was
         a binary search tree, as it does not check the root value of subtrees. 
         This method will simply insert a node on the right side if it's value is bigger, else insert at left.*/
        public void InsertInOrder(Node root, Node newNode)
        {
            if (root == null)
            {
                root = newNode;
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
                root.left = newNode;
                return;
            }
        }
    }
}