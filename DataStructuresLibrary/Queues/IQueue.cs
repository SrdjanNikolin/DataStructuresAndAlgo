﻿namespace DataStructuresLibrary.Queues
{
    public interface IQueue<T> //See IStack for more operations
    {
        void Enqueue(T data);
        void Dequeue();
        T Front { get;}
        T Rear { get;}
        int Count { get; }
    }
}