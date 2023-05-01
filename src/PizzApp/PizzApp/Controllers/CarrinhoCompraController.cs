using Microsoft.AspNetCore.Mvc;
using PizzApp.Models;
using PizzApp.Repositories.Interfaces;
using PizzApp.ViewModels;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace PizzApp.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly Repositories.Interfaces.IPizzaRepository _pizzaRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(Repositories.Interfaces.IPizzaRepository pizzaRepository, CarrinhoCompra carrinhoCompra)
        {
            _pizzaRepository = pizzaRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        [Authorize]
        public IActionResult AdicionarItemNoCarrinhoCompra(int pizzaId)
        {
            var pizzaSelecionada = _pizzaRepository.Pizzas.FirstOrDefault(p=> p.PizzaId == pizzaId);

            if (pizzaSelecionada != null)
            {
                _carrinhoCompra.AdicionarAoCarrinho(pizzaSelecionada);
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public IActionResult RemoverItemDoCarrinhoCompra(int pizzaId)
        {
            var pizzaSelecionada = _pizzaRepository.Pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);

            if (pizzaSelecionada != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(pizzaSelecionada);
            }

            return RedirectToAction("Index");
        }
    }
}
