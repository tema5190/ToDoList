using System.Collections.Generic;
using System.Linq;
using ModelsAndServices.Exceptions;
using ModelsAndServices.Models;

namespace ModelsAndServices.Services
{
    public class TaskProvider : ITaskProvider
    {

        private readonly TaskContext db;

        public TaskProvider()
        {
            db = new TaskContext();
        }


        public void Create(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
        }

        public Task GetById(int id)
        {
            Task result = db.Tasks.FirstOrDefault(t => t.Id == id);

            if (result==null)
                throw new TaskNotFoundException();

            return result;
        }

        public List<Task> GetAll()
        {
            if(db.Tasks==null)
                throw new DataBaseIsEmptyException();

            return db.Tasks.ToList();
        }

        public void Update(int id, Task newTask)
        {
            Task oldTask = db.Tasks.FirstOrDefault(t => t.Id == id);
            if(oldTask==null)
                throw new TaskNotFoundException();
            Copy(oldTask,newTask);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Task victim = db.Tasks.FirstOrDefault(t => t.Id == id);
            if(victim==null)
                throw new TaskNotFoundException();
            db.Tasks.Remove(victim);
            db.SaveChanges();
        }

        private static void Copy(Task lt, Task rt)
        {
            lt.Title = rt.Title;
            lt.Description = rt.Description;
            lt.ImageUrl = rt.ImageUrl;
        }
    }
}