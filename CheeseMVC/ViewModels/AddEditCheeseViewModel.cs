using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.ViewModels
{
    public class AddEditCheeseViewModel : AddCheeseViewModel
    {
        public int CheeseId { get; set; }
    }
}
