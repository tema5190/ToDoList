﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Controllers
{
    public class AngularClientController : Controller
    {
        // GET: AngularClient
        public ActionResult Index()
        {
            return View();
        }
    }
}