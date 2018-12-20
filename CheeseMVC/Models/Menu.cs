﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CheeseMVC.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class Menu
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public IList<CheeseMenu> CheeseMenus { get; set; }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class MenuExtensions
    //{
    //    public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<Menu>();
    //    }
    //}
}
