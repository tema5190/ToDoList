using System;
using System.Web.Mvc;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        private readonly TaskProvider _provider;

        public TaskController()
        {
            _provider = new TaskProvider();
        }

        #region Create
        [HttpGet]
        [Route("~/Create")]
        public ActionResult Create()
        {
            return View("Create");
        }

        [Route("~/Create")]
        [HttpPost]
        public ActionResult Create(Task task)
        {
            _provider.Create(task);
            return RedirectToAction("Index", task.Id);
        }
        #endregion

        #region Read
        [Route("~/Detail")]
        public ActionResult Index()
        {
            return View(_provider.GetAll());
        }

        [Route("~/Detail/{id}")]
        public ActionResult Read(int id)
        {
            Task task;
            try
            {
                task = _provider.GetById(id);
            }
            catch (Exception e)
            {
                return View("Exception", e);
            }
            return View("Read", task);
        }


        #endregion


        #region Update
        [Route("~/Edit/{id}")]
        [HttpGet]
        public ActionResult Update(int id)
        {
            Task task;
            try
            {
                task = _provider.GetById(id);
            }
            catch(Exception e)
            {
                return View("Exception", e);
            }
            return View(task);
        }

        [HttpPost]
        [Route("~/Edit/{id}")]
        public ActionResult Update(int id, Task task)
        {
            _provider.Update(id,task);
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
        [Route("~/Delete/{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _provider.Delete(id);
            }
            catch (Exception e)
            {
                return View("Exception", e);
            }
            return RedirectToAction("Index");
        }
        #endregion
    }
}