using System;
using LinkedListTests;
using DataStructuresLibrary.Queues.ArrayBasedQueue;
using DataStructuresLibrary.Queues;
namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<string> arrayQueue = new ArrayBasedQueue<string>(6);
            arrayQueue.Enqueue("Bob");
            arrayQueue.Enqueue("Mark");
            arrayQueue.Enqueue("Timmy");
            arrayQueue.Enqueue("John");
            arrayQueue.Dequeue();
            arrayQueue.Dequeue();
            arrayQueue.Dequeue();
            arrayQueue.Dequeue();
            string front = arrayQueue.Front;
            string rear = arrayQueue.Rear;
        }
    }
}