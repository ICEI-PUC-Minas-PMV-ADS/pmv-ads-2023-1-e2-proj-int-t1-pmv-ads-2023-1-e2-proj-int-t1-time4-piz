using Microsoft.AspNetCore.Mvc;
using PizzApp.Models;
using PizzApp.Repositories.Interfaces;
using System.Collections.Generic;
using PizzApp.Areas.Admin.Servicos;

namespace PizzApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRelatorioEstoqueController : Controller
    {
        private readonly IEstoqueRepositorio _estoqueRepositorio;
        public AdminRelatorioEstoqueController(IEstoqueRepositorio estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }
        public IActionResult Index()
        {
            List<EstoqueModel> produtos = _estoqueRepositorio.BuscarTodos();

            return View(produtos);
        }

        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            EstoqueModel produto = _estoqueRepositorio.ListarPorId(id);
            return View(produto);
        }
        public IActionResult RemoverConfirmacao(int id)
        {
            EstoqueModel produto = _estoqueRepositorio.ListarPorId(id);
            return View(produto);
        }

        public IActionResult Remover(int id)
        {
            _estoqueRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Criar(EstoqueModel produto)
        {
            _estoqueRepositorio.Adicionar(produto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Alterar(EstoqueModel produto)
        {
            _estoqueRepositorio.Atualizar(produto);
            return RedirectToAction("Index");
        }
    }
}
