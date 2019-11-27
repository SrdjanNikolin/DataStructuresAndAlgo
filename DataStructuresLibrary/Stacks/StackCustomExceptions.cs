using System;

namespace Stacks
{
    //TODO: Make changes
    public class StackCustomExceptions
    {
        //Overflow exception
        public class ExceededSizeException : Exception { }
        //List is empty exception, change name and add more specific exception
        public class ExpenditureProhibitedException : Exception { }
    }
}