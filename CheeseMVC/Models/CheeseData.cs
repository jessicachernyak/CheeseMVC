using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheeseMVC.Models
{
    public class CheeseData
    {
        static readonly private List<Cheese> cheeses = new List<Cheese>();

        //GetAll
        public static List<Cheese> GetAll()
        {
            return cheeses;
        }

        //Add
        public static void Add(Cheese newCheese)
        {
            cheeses.Add(newCheese);
        }

        //Remove
        public static void Remove(int id)
        {
            Cheese cheeseToRemove = GetById(id);
            cheeses.Remove(cheeseToRemove);
        }

        //GetById
        public static Cheese GetById(int id)
        {
            return cheeses.Single(cheese => cheese.CheeseId == id);
        }
    }
}