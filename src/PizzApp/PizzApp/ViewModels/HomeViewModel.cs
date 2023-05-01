using PizzApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace PizzApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Pizza> PizzasPreferidas { get; set; }
    }
}
