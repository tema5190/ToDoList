using System;
using System.Web.Mvc;
using ModelsAndServices.Models;
using ModelsAndServices.Services;

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
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Task task)
        {
            _provider.Create(task);
            return RedirectToAction("Index", task.Id);
        }
        #endregion

        #region Read
        public ActionResult Index()
        {
            ViewBag.Desc = false;
            var taskList = _provider.GetAll();
            return View(taskList);
        }

        public ActionResult Read(int id)
        {
            ViewBag.Desc = true;
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
        public ActionResult Update(int id, Task task)
        {
            _provider.Update(id,task);
            return RedirectToAction("Index");
        }
        #endregion

        #region Delete
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