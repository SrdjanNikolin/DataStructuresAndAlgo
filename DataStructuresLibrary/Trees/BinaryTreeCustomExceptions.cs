using System;

namespace DataStructuresLibrary.Trees
{
    public static class BinaryTreeCustomExceptions
    {
        public class TreeIsEmptyException : Exception
        {
            public TreeIsEmptyException(string message) : base(message) { }
        }
    }
}