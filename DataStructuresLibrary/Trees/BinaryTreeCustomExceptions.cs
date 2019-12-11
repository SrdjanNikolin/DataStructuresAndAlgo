using System;

namespace DataStructuresLibrary.Trees
{
    public static class BinaryTreeCustomExceptions
    {
        public class TreeIsEmptyException : Exception
        {
            public TreeIsEmptyException(string message) : base(message) { }
        }
        public class ValueNotFoundException : Exception
        {
            public ValueNotFoundException(string message) : base(message) { }
        }
    }
}