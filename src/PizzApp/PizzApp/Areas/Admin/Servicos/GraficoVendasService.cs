using PizzApp.Context;
using PizzApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzApp.Areas.Admin.Servicos
{
    public class GraficoVendasService
    {
        private readonly AppDbContext context;

        public GraficoVendasService(AppDbContext context)
        {
            this.context = context;
        }

        public List<PizzaGrafico> GetVendasPizzas(int dias = 360)
        {
            var data = DateTime.Now.AddDays(-dias);

            var pizzas = (from pd in context.PedidosDetalhes
                          join l in context.Pizzas on pd.PizzaId equals l.PizzaId
                          where pd.Pedido.PedidoEnviado >= data
                          group pd by new { pd.PizzaId, l.PizzaName, pd.Quantidade }
                          into g
                          select new
                          {
                              PizzaNome = g.Key.PizzaName,
                              PizzasQuantidade = g.Sum(q=> q.Quantidade),
                              PizzasValorTotal = g.Sum(a=> a.Preco * a.Quantidade)
                          });
            var lista = new List<PizzaGrafico>();

            foreach(var item in pizzas)
            {
                var pizza = new PizzaGrafico();
                pizza.PizzaNome = item.PizzaNome;
                pizza.PizzasQuantidade = item.PizzasQuantidade;
                pizza.PizzasValorTotal = item.PizzasValorTotal;
                lista.Add(pizza);
            }
            return lista;
        }
    }
}
