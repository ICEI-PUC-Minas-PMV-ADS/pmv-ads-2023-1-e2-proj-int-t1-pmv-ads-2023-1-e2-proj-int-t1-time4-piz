using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PizzApp.Models;
using PizzApp.Repositories.Interfaces;
using PizzApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzApp.Controllers
{
    public class PizzaController : Controller
    {
        private readonly Repositories.Interfaces.IPizzaRepository _pizzaRepository;

        public PizzaController(Repositories.Interfaces.IPizzaRepository pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public IActionResult List(string categoria)
        {
            IEnumerable<Pizza> pizzas;
            string categoriaAtual = string.Empty;
            if (string.IsNullOrEmpty(categoria))
            {
                pizzas = _pizzaRepository.Pizzas.OrderBy(l => l.PizzaId);
                categoriaAtual = "Todos as Pizzas";
            }
            else
            {
                //if(string.Equals("Salgada", categoria, StringComparison.OrdinalIgnoreCase))
                //{
                //   pizzas = _pizzaRepository.Pizza.Where(l => l.Categoria.CategoriaName.Equals("Salgada")).OrderBy(l => l.PizzaName);
                //}
                // else
                // {
                //     pizzas = _pizzaRepository.Pizza.Where(l => l.Categoria.CategoriaName.Equals("Doce")).OrderBy(l => l.PizzaName);
                // }

                pizzas = _pizzaRepository.Pizzas.Where(l => l.Categoria.CategoriaName.Equals(categoria)).OrderBy(c => c.PizzaName);
                categoriaAtual = categoria;
            }

            var pizzasListViewModel = new PizzaListViewModel
            {
                Pizzas = pizzas,
                CategoriaAtual = categoriaAtual

            };

            return View(pizzasListViewModel);
        }

        public IActionResult Details(int pizzaId)
        {
            var pizza = _pizzaRepository.Pizzas.FirstOrDefault(l => l.PizzaId == pizzaId);
            return View(pizza);
        }

        public ViewResult Search(string searchString)
        {
            IEnumerable<Pizza> pizzas;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(searchString))
            {
                pizzas = _pizzaRepository.Pizzas.OrderBy(p => p.PizzaId);
                categoriaAtual = "Todas as Pizzas";
            }
            else
            {
                pizzas = _pizzaRepository.Pizzas
                          .Where(p => p.PizzaName.ToLower().Contains(searchString.ToLower()));

                if (pizzas.Any())
                    categoriaAtual = "Pizzas";
                else
                    categoriaAtual = "Nenhuma Pizza foi encontrada";
            }

            return View("~/Views/Pizza/List.cshtml", new PizzaListViewModel
            {
                Pizzas = pizzas,
                CategoriaAtual = categoriaAtual
            });
        }

    }
}
