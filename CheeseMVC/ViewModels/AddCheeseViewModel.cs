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

        public CheeseCategory Category { get; set; }

        public List<SelectListItem> CheeseCategories { get; set; }

        [Range(1, 5)]
        // How to display error message without making it required?
        public int Rating { get; set; }

        [Required]
        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public List<SelectListItem> Categories { get; set; }

        public AddCheeseViewModel(IEnumerable<CheeseCategory> categories)
        {
            Categories = new List<SelectListItem>();
            foreach(CheeseCategory category in categories)
            {
                SelectListItem cheeseCategory = new SelectListItem
                {
                    Value = ((int)category.ID).ToString(),
                    Text = category.Name
                };

                Categories.Add(cheeseCategory);

            }

        }

        public AddCheeseViewModel()
        {

        }
    }
}