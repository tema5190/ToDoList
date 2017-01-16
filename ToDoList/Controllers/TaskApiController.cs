using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    public class TaskApiController : ApiController
    {
        private readonly TaskProvider _provider;

        public TaskApiController()
        {
            _provider = new TaskProvider();
        }

        public Create(Task newTask)
        {
            _provider.Create(newTask);
        }
    }
}
