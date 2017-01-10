using System;
using Microsoft.Ajax.Utilities;

namespace ToDoList.Exceptions
{
    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException() : base("Task not found or not exist")
        {
            
        }
    }
}