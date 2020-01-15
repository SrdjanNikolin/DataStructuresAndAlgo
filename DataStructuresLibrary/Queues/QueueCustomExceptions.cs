using System;

namespace DataStructuresLibrary.Queues
{
    public class QueueCustomExceptions
    {
        //Exception thrown when attempting to enqueue data when queue is already full
        public class QueueOverflowException : OverflowException { }
        //Exception thrown when attempting to remove data from an empty queue
        public class QueueUnderflowException : Exception 
        {
            public QueueUnderflowException(string message) : base(message) { }
        }
    }
}