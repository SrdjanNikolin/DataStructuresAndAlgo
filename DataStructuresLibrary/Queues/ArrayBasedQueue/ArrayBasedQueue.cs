using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresLibrary.Queues.ArrayBasedQueue
{
    public class ArrayBasedQueue<T> : IQueue<T> //Optimize
    {
        private T[] arrayQueue;
        private int maxCapacity;
        private int frontIndex;
        private int rearIndex;
        private T[] temporaryArray;
        public T Front { get; private set; }
        public T Rear { get; private set; }
        public ArrayBasedQueue(int capacity)
        {
            maxCapacity = capacity;
            arrayQueue = new T[maxCapacity];
            temporaryArray = new T[maxCapacity];
        }
        public void Enqueue(T data)
        {
            if (rearIndex == maxCapacity)
            {
                Console.WriteLine("Queue is full");
                return;//Check to see if it's correct;
            }
            arrayQueue[rearIndex] = data;
            rearIndex++;
            Rear = arrayQueue[rearIndex - 1];
            Front = arrayQueue[0];
        }

        public void Dequeue()
        {
            if (rearIndex == 0 || arrayQueue[0] == null)
            {
                throw new Exception(); //Underflow exception
            }
            else if (rearIndex == 1)
            {
                arrayQueue[0] = default;
            }        
            for (int index = 1; index <= rearIndex; index++) 
            {
                temporaryArray[index-1] = arrayQueue[index];
            }
            rearIndex--;
            for (int index2 = 0; index2 < rearIndex; index2++)
            {
                arrayQueue[index2] = temporaryArray[index2];
            }
            if (rearIndex == 0)
            {
                Rear = arrayQueue[rearIndex];
            }
            else
            {
                Rear = arrayQueue[rearIndex - 1];
            }
            Front = arrayQueue[0];
        }
     
    }
}