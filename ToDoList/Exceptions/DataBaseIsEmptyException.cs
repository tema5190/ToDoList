using System;

namespace ToDoList.Exceptions
{
    public class DataBaseIsEmptyException : Exception
    {
        public DataBaseIsEmptyException() : base("Data base is empty")
        {
            
        }
    }
}