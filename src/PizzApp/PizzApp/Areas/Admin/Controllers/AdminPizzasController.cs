using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using PizzApp.Context;
using PizzApp.Models;
using ReflectionIT.Mvc.Paging;

namespace PizzApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class AdminPizzasController : Controller
    {
        private readonly AppDbContext _context;

        public AdminPizzasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminPizzas



        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Pizzas.Include(p => p.Categoria);
            return View(await appDbContext.ToListAsync());
        }


        // GET: Admin/AdminPizzas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        //GET: Admin/AdminPizzas/Create
        public IActionResult Create()
        {
            ViewBag.CategoriaId = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName");
            return View();
        }

        // POST: Admin/AdminPizzas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PizzaId,PizzaName,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsPizzaPreferida,EmEstoque,CategoriaId")] Pizza pizza)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizza);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CategoriaId = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", pizza.CategoriaId);
            return View(pizza);
        }

        // GET: Admin/AdminPizzas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", pizza.CategoriaId);
            return View(pizza);
        }

        // POST: Admin/AdminPizzas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaId,PizzaName,DescricaoCurta,DescricaoDetalhada,Preco,ImagemUrl,ImagemThumbnailUrl,IsPizzaPreferida,EmEstoque,CategoriaId")] Pizza pizza)
        {
            if (id != pizza.PizzaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizza);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaExists(pizza.PizzaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categorias, "CategoriaId", "CategoriaName", pizza.CategoriaId);
            return View(pizza);
        }

        // GET: Admin/AdminPizzas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(m => m.PizzaId == id);
            if (pizza == null)
            {
                return NotFound();
            }

            return View(pizza);
        }

        // POST: Admin/AdminPizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaExists(int id)
        {
            return _context.Pizzas.Any(e => e.PizzaId == id);
        }
    }
}
