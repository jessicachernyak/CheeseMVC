using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {

        // static private List<string> Cheeses = new List<string>();
        // static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();
        static private List<Cheese> cheeses = new List<Cheese>();

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = cheeses;

            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(string name, string description)
        {
            Cheese cheese = new Cheese(name, description);
            cheeses.Add(cheese);

            return Redirect("/Cheese");
        }

        [HttpPost]
        public IActionResult RemoveCheese(List<string> rmvcheese)
        {
            cheeses.RemoveAll(cheese => rmvcheese.Contains(cheese.name));

            return Redirect("/Cheese");
        }
    }
}
