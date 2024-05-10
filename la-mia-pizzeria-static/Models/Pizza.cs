﻿namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string? Name { get; set; }

        public string? Description { get; set; }

        public string? PizzaImg { get; set; }

        public decimal? Price { get; set; }


        public Pizza() { }

        public Pizza(string name, string description, string pizzaImg, decimal price) 
        {
            this.Name = name;
            this.Description = description;
            this.PizzaImg = pizzaImg;
            this.Price = price;
        }
    }

   
}
