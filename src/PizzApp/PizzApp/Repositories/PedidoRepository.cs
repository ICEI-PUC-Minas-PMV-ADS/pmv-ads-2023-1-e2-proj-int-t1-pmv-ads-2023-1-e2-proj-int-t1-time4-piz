using PizzApp.Context;
using PizzApp.Models;
using PizzApp.Repositories.Interfaces;
using System;

namespace PizzApp.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItens;

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetail = new PedidoDetalhe()
                {
                    Quantidade = carrinhoItem.Quantidade,
                    PizzaId = carrinhoItem.Pizza.PizzaId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Pizza.Preco
                };

                _appDbContext.PedidosDetalhes.Add(pedidoDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
