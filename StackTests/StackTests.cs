using NUnit.Framework;
using DataStructuresLibrary.Stacks.ListBasedStack;
using static Stacks.StackCustomExceptions;
using DataStructuresLibrary.Stacks;
using DataStructuresLibrary.Stacks.LinkedListBasedStack;

namespace StackTests
{
    public class StackTests
    {
        [Test]
        public void Creation()
        {
            IStack<int> liststack = new ListBasedStack<int>(3);
            IStack<string> linkedListStack = new LinkedListBasedStack<string>();
            Assert.AreEqual(0, liststack.Count());
            Assert.AreEqual(0, linkedListStack.Count());
        }
        [Test]
        public void Push_Peek()
        {
            IStack<int> listStack = new ListBasedStack<int>();
            listStack.Push(5);
            listStack.Push(10);
            int peekLastFromListStack = listStack.Peek();
            //
            IStack<string> linkedListStack = new LinkedListBasedStack<string>();
            linkedListStack.Push("Bob");
            linkedListStack.Push("Mark");
            string peekLastFromLinkedListStack = linkedListStack.Peek();

            Assert.AreEqual(10, peekLastFromListStack);
            Assert.AreEqual("Mark", peekLastFromLinkedListStack);
        }
        [Test]
        public void Push_Pop()
        {
            IStack<int> listStack = new ListBasedStack<int>(3);
            listStack.Push(1);
            listStack.Push(2);
            listStack.Push(3);

            int value = listStack.Pop();
            //
            IStack<string> linkedListStack = new LinkedListBasedStack<string>();
            linkedListStack.Push("Bob");
            linkedListStack.Push("Mark");
            linkedListStack.Push("Tim");

            string stringValue = linkedListStack.Pop();

            Assert.AreEqual(3, value);
            Assert.AreEqual(2, listStack.Count());
            Assert.AreEqual("Tim", stringValue);
            Assert.AreEqual(2, linkedListStack.Count());
        }
        [Test]
        public void Too_Much_Pop()
        {
            IStack<int> listStack = new ListBasedStack<int>(3);
            IStack<string> linkedListStack = new LinkedListBasedStack<string>();
            Assert.Throws<ExpenditureProhibitedException>(() => listStack.Pop());
            Assert.Throws<ExpenditureProhibitedException>(() => linkedListStack.Pop());
        }
        [Test]
        public void Too_Much_Push()
        {
            IStack<int> listStack = new ListBasedStack<int>(3);
            listStack.Push(1);
            listStack.Push(2);
            listStack.Push(3);
            Assert.Throws<ExceededSizeException>(() => listStack.Push(4));
        }
        [Test]
        public void Contains_Value()
        {
            IStack<int> listStack = new ListBasedStack<int>();
            listStack.Push(5);
            listStack.Push(10);

            IStack<string> linkedListStack = new LinkedListBasedStack<string>();
            linkedListStack.Push("Bob");
            linkedListStack.Push("Tim");
            linkedListStack.Push("Jim");

            Assert.IsTrue(listStack.Contains(10));
            Assert.IsTrue(linkedListStack.Contains("Tim"));
        }
        [Test]
        public void Does_Not_Contain_Value()
        {
            IStack<int> listStack = new ListBasedStack<int>();
            listStack.Push(5);
            listStack.Push(10);

            IStack<string> linkedListStack = new LinkedListBasedStack<string>();
            linkedListStack.Push("Bob");
            linkedListStack.Push("Tim");
            linkedListStack.Push("Jim");

            Assert.IsFalse(listStack.Contains(20));
            Assert.IsFalse(linkedListStack.Contains("TIM"));
        }
        [Test]
        public void Clear_Stack()
        {
            IStack<int> listStack = new ListBasedStack<int>();
            listStack.Push(5);
            listStack.Clear();

            IStack<string> linkedListStack = new LinkedListBasedStack<string>();
            linkedListStack.Push("Bob");
            linkedListStack.Clear();

            Assert.AreEqual(0, listStack.Count());
            Assert.AreEqual(0, linkedListStack.Count());
        }
    }
}