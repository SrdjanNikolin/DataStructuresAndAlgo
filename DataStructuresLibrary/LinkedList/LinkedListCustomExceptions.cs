using System;

namespace LinkedListTests
{
    public class LinkedListCustomExceptions
    {
        public class WrongFileFormatException : Exception
        {
            public WrongFileFormatException(string message) : base(message) { }
        }
        public class ListIsEmptyException : Exception
        {
            public ListIsEmptyException(string message) : base(message) { }
        }
    }
}