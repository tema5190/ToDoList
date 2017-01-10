using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Services
{
    public interface ITaskProvider
    {
        void Create(Task task);

        Task GetById(int id);

        List<Task> GetAll();

        void Update(int id, Task newTask);

        void Delete(int id);
    }
}