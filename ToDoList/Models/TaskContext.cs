using System.Data.Entity;

namespace ToDoList.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext() : base("TaskDb")
        {
            
        }

        static TaskContext()
        {
            Database.SetInitializer(new TaskContextInitializer());
        }

        public DbSet<Task> Tasks { get; set; } 

        
    }

    public class TaskContextInitializer : DropCreateDatabaseIfModelChanges<TaskContext>
    {
        protected override void Seed(TaskContext context)
        {
            for (int i = 0; i < 30; i++)
                context.Tasks.Add(new Task {Description = $"{i}.Description", Title = $"{i}.Title"});
            context.SaveChanges();
        }
    }
}