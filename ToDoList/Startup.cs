﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ToDoList.Startup))]

namespace ToDoList
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            #if DEBUG
            app.UseErrorPage();
            #endif
        }
    }
}
