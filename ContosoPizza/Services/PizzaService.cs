using System;
using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza{Id = 1, Name = "Classic Italian", IsGlutenFree = true },
            new Pizza{Id = 2, Name = "Veggie", IsGlutenFree = false}
        };
    }

    public static List<Pizza> GetAll() => Pizzas;
    public static Pizza? Get(int Id) => Pizzas.FirstOrDefault((el) => el.Id == Id);
    public static void Add(Pizza pizza)
    {
        nextId++;
        Pizzas.Add(pizza);
    }
    public static void Edit(Pizza pizza)
    {
        int index = Pizzas.FindIndex((p) => p.Id == pizza.Id);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }
    public static void Delete(int Id)
    {
        var pizza = Get(Id);
        if (pizza == null)
            return;

        Pizzas.Remove(pizza);
    }
}
