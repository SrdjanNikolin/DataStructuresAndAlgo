using DataStructuresLibrary.Queues.ArrayBasedQueue;
using DataStructuresLibrary.Queues;
namespace FastTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueue<int> myQueue = new ArrayBasedQueue<int>(10);
            myQueue.Enqueue(5);
            myQueue.Enqueue(10);
            int front = myQueue.Front;
            int rear = myQueue.Rear;
        }
    }
}