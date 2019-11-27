using System.Collections.Generic;
using static Stacks.StackCustomExceptions;

namespace DataStructuresLibrary.Stacks.ListBasedStack
{
    public class ListBasedStack<T> : IStack<T>
    {
        private List<T> stackList;
        public int MaxCapacity { get; private set; }
        public ListBasedStack()
        {
            stackList = new List<T>();
        }
        public ListBasedStack(int capacity = 0)
        {          
            if (capacity == 0)
            {
                stackList = new List<T>();
            }
            else
            {
                MaxCapacity = capacity;
                stackList = new List<T>(MaxCapacity);
            }
        }
        public int Count()
        {
            return stackList.Count;
        }
        public void Push(T value)
        {
            if (MaxCapacity != 0 && stackList.Count == MaxCapacity)
            {
                throw new ExceededSizeException();
            }
            stackList.Add(value);
        }
        public T Peek()
        {
            if (stackList.Count == 0)
            {
                throw new ExpenditureProhibitedException();
            }
            T result = stackList[stackList.Count - 1];
            return result;
        }
        public T Pop()
        {         
            if (stackList.Count == 0)
            {
                throw new ExpenditureProhibitedException();
            }
            T result = stackList[stackList.Count-1];
            stackList.RemoveAt(stackList.Count - 1);
            return result;
        }
        public bool Contains(T value)
        {
            if (stackList.Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Clear()
        {
            stackList.Clear();
        }
    }
}