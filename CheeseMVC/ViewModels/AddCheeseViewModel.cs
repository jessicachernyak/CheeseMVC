using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must provide a description.")]
        public string Description { get; set; }

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        [Range(1,5)]
        // How to display error message without making it required?
        public int rating { get; set; }

        public AddCheeseViewModel()
        {
            CheeseTypes = new List<SelectListItem>();

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int) CheeseType.Yellow).ToString(),
                Text = CheeseType.Yellow.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.White).ToString(),
                Text = CheeseType.White.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Blue).ToString(),
                Text = CheeseType.Blue.ToString()
            });
        }

        //public CreateCheese()
        //{
        //    return ;
        //}
    }
}