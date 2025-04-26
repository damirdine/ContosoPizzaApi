using System;
using ContosoPizza.Models;

namespace ContosoPizza.Services;

public class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>() {
            new Pizza{Id = 1, Name = "Classic Italian", IsGlutenFree = true },
            new Pizza{Id = 2, Name = "Veggie", IsGlutenFree = false}
        };
    }

}
