﻿namespace PizzaStoreAPi.Models
{
    public class PizzaDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Ingredients { get; set; }
    }
}