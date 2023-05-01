using PizzApp.Context;
using PizzApp.Models;
using PizzApp.Repositories.Interfaces;
using System.Collections.Generic;

namespace PizzApp.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
