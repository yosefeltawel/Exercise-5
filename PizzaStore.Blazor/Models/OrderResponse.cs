using System.Collections.Generic;

namespace PizzaStore.Blazor.Models
{
    public class OrderResponse
    {
        public class Pizza
        {
            public int Id { get; set; }
            public decimal Price { get; set; }
            public string Name { get; set; }
        }
        public class Topping
        {
            public string Name { get; set; }
                        public decimal Price { get; set; }
        }
        public class PizzaTopping
        {
            public Topping Topping { get; set; }
            public int ToppingId { get; set; }
        }

        public class PizzaResponse
        {
            public Pizza Pizza { get; set; }
            public int PizzaId { get; set; }
            public List<PizzaTopping> PizzaWithToppings { get; set; }
        }

        public int Id { get; set; }
        public string Note { get; set; }
        public List<PizzaResponse> OrderPizzas { get; set; }
        public decimal TotalCost { get; set; }
        
    }
}