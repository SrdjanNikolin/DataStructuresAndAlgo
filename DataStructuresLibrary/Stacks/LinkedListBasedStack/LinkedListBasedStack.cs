using System;
using System.Collections.Generic;
using System.Text;
using static Stacks.StackCustomExceptions;
namespace DataStructuresLibrary.Stacks.LinkedListBasedStack
{
    public class LinkedListBasedStack<T> : IStack<T>
    {
        public Node<T> Head { get; private set; }

        private int nodeCount;
        public LinkedListBasedStack()
        {
            Head = null;
        }

        public int Count()
        {
            return nodeCount;
        }

        public void Push(T value)
        {
            if (Head == null)
            {
                Head = new Node<T>(value);
                nodeCount++;
                return;
            }
            Node<T> node = Head;
            while (node.next != null)
            {
                node = node.next;
            }
            node.next = new Node<T>(value);
            nodeCount++;
        }

        public T Peek()
        {
            if (Head == null)
            {
                throw new ExpenditureProhibitedException();
            }
            Node<T> node = Head;
            while (node.next != null)
            {
                node = node.next;
            }
            return node.Data;
        }

        public T Pop()
        {
            if (Head == null)
            {
                throw new ExpenditureProhibitedException();
            }
            Node<T> node = Head;
            while (node.next != null)
            {
                node = node.next;
            }
            T result = node.Data;
            node = null;
            nodeCount--;
            return result;
        }

        public bool Contains(T value)
        {
            if (Head == null)
            {
                return false;
            }
            Node<T> node = Head;
            bool result = false;
            while (node != null)
            {
                if (Comparer<T>.Default.Compare(node.Data, value) == 0)
                {
                    return true;
                }
                else
                {
                    node = node.next;
                }            
            }
            return result;
        }

        public void Clear()
        {
            Head = null;
            nodeCount = 0;
        }
    }
}