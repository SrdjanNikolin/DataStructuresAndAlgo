using NUnit.Framework;
using DataStructuresLibrary.Queues;
using DataStructuresLibrary.Queues.ArrayBasedQueue;
namespace QueueTests
{
    public class Tests
    {
        [Test]
        public void Creation()
        {
            IQueue<int> arrayQueue = new ArrayBasedQueue<int>(5);
            arrayQueue.Enqueue(5);
            Assert.AreEqual(1, arrayQueue.Count);
        }
        [Test]
        public void Enqueue_PeekFront_PeekRear()
        {
            IQueue<int> arrayQueue = new ArrayBasedQueue<int>(5);
            arrayQueue.Enqueue(5);
            arrayQueue.Enqueue(10);

            IQueue<string> arrayStringQueue = new ArrayBasedQueue<string>(5);
            arrayStringQueue.Enqueue("Bob");
            arrayStringQueue.Enqueue("John");

            Assert.AreEqual(5, arrayQueue.Front);
            Assert.AreEqual("Bob", arrayStringQueue.Front);
            Assert.AreEqual(10, arrayQueue.Rear);
            Assert.AreEqual("John", arrayStringQueue.Rear);
        }
        [Test]
        public void Enqueue_Dequeue_PeekFront_PeekRear()
        {
            IQueue<int> arrayQueue = new ArrayBasedQueue<int>(5);
            arrayQueue.Enqueue(5);
            arrayQueue.Enqueue(10);
            arrayQueue.Enqueue(15);
            arrayQueue.Dequeue();
            arrayQueue.Dequeue();

            IQueue<string> arrayStringQueue = new ArrayBasedQueue<string>(5);
            arrayStringQueue.Enqueue("Bob");
            arrayStringQueue.Enqueue("John");
            arrayStringQueue.Enqueue("Max");
            arrayStringQueue.Dequeue();

            Assert.AreEqual(15, arrayQueue.Front);
            Assert.AreEqual("John", arrayStringQueue.Front);
            Assert.AreEqual(15, arrayQueue.Rear);
            Assert.AreEqual("Max", arrayStringQueue.Rear);
        }
    }
}