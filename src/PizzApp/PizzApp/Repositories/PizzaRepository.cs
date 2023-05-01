using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PizzApp.Context;
using PizzApp.Models;
using PizzApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzApp.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly AppDbContext _context;
        public PizzaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        public IEnumerable<Pizza> Pizzas => _context.Pizzas.Include(c => c.Categoria);

        public IEnumerable<Pizza> PizzasPreferidas => _context.Pizzas.Where(l => l.IsPizzaPreferida).Include(c => c.Categoria);

        public Pizza GetPizzaById(int pizzaId)
        {
            throw new System.NotImplementedException();
        }
    }

}    
