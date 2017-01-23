using System;

namespace ModelsAndServices.Exceptions
{
    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException() : base("Task not found or not exist")
        {
            
        }
    }
}