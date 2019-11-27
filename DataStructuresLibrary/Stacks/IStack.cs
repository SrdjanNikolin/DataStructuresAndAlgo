namespace DataStructuresLibrary.Stacks
{
    public interface IStack<T> //Maybe Peek should be a property?
    {
        int Count();
        void Push(T value);
        T Peek();
        T Pop();
        bool Contains(T value);
        void Clear();
    }
}