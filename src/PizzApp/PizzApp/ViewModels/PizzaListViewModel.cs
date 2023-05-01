using PizzApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace PizzApp.ViewModels
{
    public class PizzaListViewModel
    {
        public IEnumerable<Pizza> Pizzas { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
