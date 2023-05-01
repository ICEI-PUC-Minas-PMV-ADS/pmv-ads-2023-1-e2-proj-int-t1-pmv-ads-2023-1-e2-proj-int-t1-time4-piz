using PizzApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace PizzApp.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
