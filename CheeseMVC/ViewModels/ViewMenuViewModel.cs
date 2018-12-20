using System.Collections.Generic;
using CheeseMVC.Models;


namespace CheeseMVC.ViewModels
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ViewMenuViewModel
    {
        public Menu Menu { get; set; }

        public IList<CheeseMenu> Items { get; set; }
    }
}
