using System.Collections.Generic;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public int CheeseID { get; set; }
        public int MenuID { get; set; }

        public Menu Menu { get; set; }
        // public List<SelectListItem> Cheeses { get; set; }
        public List<SelectListItem> Cheeses = new List<SelectListItem>();

        public AddMenuItemViewModel()
        {

        }

        public AddMenuItemViewModel(Menu Menu, IEnumerable<Cheese> cheeses)
        {
            foreach (var cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }
        }
    }
}
