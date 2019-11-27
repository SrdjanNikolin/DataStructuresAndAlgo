using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListTests
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
}