using PizzApp.Models;
using System.Collections.Generic;

namespace PizzApp.Controllers
{
    internal interface IPizzaRepository
    {
        IEnumerable<Pizza> PizzasPreferidas { get; }
    }
}