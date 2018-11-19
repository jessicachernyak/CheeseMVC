using System;
namespace CheeseMVC.Models
{
    public class Cheese
    {
        public string name;
        public string description;

        public Cheese(string name, string description) {
            this.name = name;
            this.description = description;
        }
    }
}
