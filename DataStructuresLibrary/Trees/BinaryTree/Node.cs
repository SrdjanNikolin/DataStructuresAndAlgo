using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresLibrary.Trees.BinaryTree
{
    public class Node
    {
        public int Data { get; private set; }
        public Node left, right;
        public Node(int data)
        {
            Data = data;
            left = null;
            right = null;
        }
    }
}