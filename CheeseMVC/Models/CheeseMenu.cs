using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace CheeseMVC.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class CheeseMenu
    {
        public int MenuID { get; set; }
        public Menu Menu { get; set; }

        public int CheeseID { get; set; }
        public Cheese Cheese { get; set; }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    //public static class CheeseMenuExtensions
    //{
    //    public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
    //    {
    //        return builder.UseMiddleware<CheeseMenu>();
    //    }
    //}
}
