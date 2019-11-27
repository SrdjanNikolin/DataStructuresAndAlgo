using System;

namespace LinkedListTests
{
    public class LinkedList
    {
        public Node Head { get; private set; }

        public LinkedList()
        {
            Head = null;
        }

        public void PushAtEnd(int data)
        {
            if (Head == null)
            {
                Head = new Node(data);
                return;
            }
            Node current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(data);
        }

        public int GetSumOfAllData()
        {
            int result = 0;
            Node current = Head;
            while (current != null)
            {
                result += current.Data;
                current = current.Next;
            }
            return result;
        }

        public void PrintAllData()
        {
            Node currentNode = Head;
            if (currentNode == null)
            {
                throw new LinkedListCustomExceptions.ListIsEmptyException("The list is empty!");
            }
            while (currentNode != null)
            {
                if (currentNode.Next == null)
                {
                    Console.WriteLine(currentNode.Data);
                    return;
                }
                Console.Write(currentNode.Data + " => ");
                currentNode = currentNode.Next;
            }
        }
        public void PushAtStart(int data)
        {
            Node newNode = new Node(data);
            if (Head == null)
            {
                Head = new Node(data);
                return;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }

        }
        public void PushAfterNode(Node previousNode, int data)
        {
            if (previousNode == null)
            {
                Console.WriteLine("List cannot be empty");
                return;
            }
            Node newNode = new Node(data);
            newNode.Next = previousNode.Next;
            previousNode.Next = newNode;
        }
        public int PeekLast()
        {
            Node lastNode = Head;
            if (lastNode == null)
            {
                Console.WriteLine("The list is empty!");
                return 0;
            }
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;
            }
            Console.WriteLine($"Value of last node is: {lastNode.Data}");
            return lastNode.Data;
        }

        public int Count()
        {
            Node node = Head;
            int count = 0;
            while (node != null)
            {
                count++;
                node = node.Next;
            }
            return count;
        }

        public void DeleteNode(int data)
        {
            Node previousNode = Head;
            if (Head != null && Head.Data == data)
            {
                Head = Head.Next;
                return;
            }
            else if (Head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            while (previousNode.Next != null && previousNode.Next.Data != data)
            {
                previousNode = previousNode.Next;
            }
            if (previousNode.Next == null)
            {
                Console.WriteLine("Node with given value not found.");
                return;
            }
            previousNode.Next = previousNode.Next.Next;
        }
        public void DeleteNodeAtPosition(int position)
        {
            if (Head == null)
            {
                return;
            }
            Node head = Head;
            if (position == 0)
            {
                Head = head.Next;
                return;
            }
            for (int i = 0; head != null && i < position - 1; i++)
            {
                head = head.Next;
            }
            if (head == null || head.Next == null)
            {
                return;
            }
            head.Next = head.Next.Next;
        }

        public Node Sort(Node head) //MergeSort
        {
            if (head == null || head.Next == null)
            {
                return head;
            }
            Node middle = GetMiddle(head);
            Node nextToMiddle = middle.Next;
            middle.Next = null;

            Node left = Sort(head);
            Node right = Sort(nextToMiddle);
            Node sortedList = Merge(left, right);
            return sortedList;
        }
        private Node GetMiddle(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }
            Node slow = head;
            Node fast = head.Next;

            while (fast != null)
            {
                fast = fast.Next;
                if (fast != null)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
            }
            return slow;
        }
        private Node Merge(Node left, Node right)
        {
            if (left == null)
            {
                return right;
            }
            else if (right == null)
            {
                return left;
            }
            Node result = null;
            if (left.Data <= right.Data)
            {
                result = left;
                result.Next = Merge(left.Next, right);
            }
            else
            {
                result = right;
                result.Next = Merge(left, right.Next);
            }
            return result;
        }
        public void DeleteList()
        {
            Head = null;
        }
    }
}