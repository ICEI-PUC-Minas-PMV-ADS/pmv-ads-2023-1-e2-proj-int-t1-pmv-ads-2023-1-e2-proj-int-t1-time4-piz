using PizzApp.Context;
using PizzApp.Models;
using PizzApp.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PizzApp.Repositories
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {

        private readonly AppDbContext _bancoContext;
        public EstoqueRepositorio(AppDbContext bancoContext)
        {
            _bancoContext = bancoContext;

        }

        public EstoqueModel ListarPorId(int id)
        {
            return _bancoContext.ProdutosEstoque.FirstOrDefault(x => x.Id == id);
        }

        public List<EstoqueModel> BuscarTodos()
        {
            return _bancoContext.ProdutosEstoque.ToList();
        }

        public EstoqueModel Adicionar(EstoqueModel produto)
        {
            //grava no banco de dados
            _bancoContext.ProdutosEstoque.Add(produto);
            _bancoContext.SaveChanges();

            return produto;
        }

        public EstoqueModel Atualizar(EstoqueModel produto)
        {
            EstoqueModel produtoDB = ListarPorId(produto.Id);

            if (produtoDB == null) throw new System.Exception("Houve um erro na atualização do produto");

            produtoDB.Nome_Produtos = produto.Nome_Produtos;
            produtoDB.Quantidade_Produtos = produto.Quantidade_Produtos;

            _bancoContext.ProdutosEstoque.Update(produtoDB);
            _bancoContext.SaveChanges();

            return produtoDB;

        }

        public bool Apagar(int id)
        {
            EstoqueModel produtoDB = ListarPorId(id);

            if (produtoDB == null) throw new System.Exception("Houve um erro ao remover o produto");

            _bancoContext.ProdutosEstoque.Remove(produtoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
