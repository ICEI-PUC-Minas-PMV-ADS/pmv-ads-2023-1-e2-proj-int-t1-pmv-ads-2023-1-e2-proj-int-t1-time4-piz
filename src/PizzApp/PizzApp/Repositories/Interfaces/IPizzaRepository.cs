using PizzApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace PizzApp.Repositories.Interfaces
{
    public interface IPizzaRepository
    {
        IEnumerable<Pizza> Pizzas { get; }
        IEnumerable<Pizza> PizzasPreferidas { get; }
        Pizza GetPizzaById(int pizzaId);
    }
}
