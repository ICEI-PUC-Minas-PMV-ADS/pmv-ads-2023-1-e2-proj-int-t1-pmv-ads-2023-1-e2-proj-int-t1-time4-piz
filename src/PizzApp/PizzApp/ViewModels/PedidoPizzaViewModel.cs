using PizzApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace PizzApp.ViewModels
{
    public class PedidoPizzaViewModel
    {
        public Pedido Pedido { get; set; }

        public IEnumerable<PedidoDetalhe> PedidoDetalhes { get; set; }
    }
}
