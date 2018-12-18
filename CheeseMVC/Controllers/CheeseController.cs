using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheeseMVC.Models;
using CheeseMVC.ViewModels;
using CheeseMVC.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Controllers
{
    public class CheeseController : Controller
    {
        private CheeseDbContext context;

        public CheeseController(CheeseDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Cheese> cheeses = context.Cheeses.ToList();

            return View(cheeses);
        }

        public IActionResult Add()
        {
            AddCheeseViewModel addCheeseViewModel = new AddCheeseViewModel();
            return View(addCheeseViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCheeseViewModel addCheeseViewModel)
        {
            if (ModelState.IsValid)
            {
                Cheese newCheese = new Cheese
                {
                    Name = addCheeseViewModel.Name,
                    Description = addCheeseViewModel.Description,
                    Type = addCheeseViewModel.Type,
                    rating = addCheeseViewModel.rating
                };

                context.Cheeses.Add(newCheese);
                context.SaveChanges();

                return Redirect("/Cheese");
            }
            return View(addCheeseViewModel);
        }

        public IActionResult RemoveCheese()
        {
            ViewBag.title = "Remove Cheeses";
            ViewBag.cheeses = context.Cheeses.ToList();
            return View();
        }

        [HttpPost]
        [Route("/Cheese/Remove")]
        public IActionResult RemoveCheese(int[] cheeseIds)
        {
            foreach (int cheeseId in cheeseIds)
            {
                Cheese theCheese = context.Cheeses.Single(c => c.ID == cheeseId);
                context.Cheeses.Remove(theCheese);
            }
            context.SaveChanges();
            return Redirect("/Cheese");
        }

        public IActionResult Edit(AddEditCheeseViewModel addEditCheeseViewModel)
        {
            ViewBag.title = "Edit Cheeses";
            // ViewBag.cheese = CheeseData.GetById(CheeseId);
            ViewBag.cheese = addEditCheeseViewModel.CheeseId;
            return View();
        }

        [HttpPost]
        // [Route("/Cheese/Edit")]
        public IActionResult Edit(int cheeseId, string name, string description)
        {
            Cheese cheeseToEdit = context.Cheeses.Single(c => c.ID == cheeseId);
            cheeseToEdit.Name = name;
            cheeseToEdit.Description = description;
            cheeseToEdit.ID = cheeseId;
            context.SaveChanges();
            return Redirect("/Cheese");
        }
    }
}