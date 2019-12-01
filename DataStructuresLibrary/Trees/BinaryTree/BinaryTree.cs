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
    }
}