using System;
using System.Collections.Generic;
using System.Text;

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
        //Print Nodes Inorder Traversal
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
    }
}