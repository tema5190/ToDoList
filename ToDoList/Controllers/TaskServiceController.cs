using System.Collections.Generic;
using System.Web.Http;
using ModelsAndServices.Models;
using ModelsAndServices.Services;

namespace ToDoList.Controllers
{
    public class TaskServiceController : ApiController
    {
        private readonly TaskProvider _provider;

        public TaskServiceController()
        {
            _provider = new TaskProvider();
        }


        // GET: api/Task
        public IEnumerable<Task> Get()
        {
            return _provider.GetAll();
        }

        // GET: api/Task/5
        public Task Get(int id)
        {
            return _provider.GetById(id);
        }

        // POST: api/Task
        public void Post([FromBody]Task newTask)
        {
            _provider.Create(newTask);
        }

        // PUT: api/Task/5
        public void Put(int id, [FromBody]Task newTask)
        {
            _provider.Update(id, newTask);
        }

        // DELETE: api/Task/5
        public void Delete(int id)
        {
            _provider.Delete(id);
        }
    }
}
