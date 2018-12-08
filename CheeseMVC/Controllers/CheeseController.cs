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
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.cheeses = CheeseData.GetAll();

            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [Route("/Cheese/Add")]
        public IActionResult NewCheese(Cheese newCheese)
        {
            CheeseData.Add(newCheese);

            return Redirect("/Cheese");
        }

        public IActionResult RemoveCheese()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = CheeseData.GetAll();
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult RemoveCheese(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                CheeseData.Remove(cheeseId);
            }

            // ViewBag.Cheeses = cheeses;
            return Redirect("/Cheese");
        }

        public IActionResult Edit(int CheeseId)
        {
            ViewBag.title = "Edit Cheeses";
            ViewBag.cheese = CheeseData.GetById(CheeseId);
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Edit")]
        public IActionResult Edit(int cheeseId, string name, string description)
        {
            try
            {
                Cheese cheeseToEdit = CheeseData.GetById(cheeseId);
                cheeseToEdit.Name = name;
                cheeseToEdit.Description = description;
                return Redirect("/Cheese");
            }

            catch (Exception e)
            {
                return Redirect("/Cheese");
            }


        }
    }
}
