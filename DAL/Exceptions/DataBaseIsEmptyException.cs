using System;

namespace ModelsAndServices.Exceptions
{
    public class DataBaseIsEmptyException : Exception
    {
        public DataBaseIsEmptyException() : base("Data base is empty")
        {
            
        }
    }
}