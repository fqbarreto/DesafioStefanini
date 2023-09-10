using Desafio.Domain.RepoInterfaces;
using Desafio.Infra.Database;
using Desafio.Infra.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Infra.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly DataContext _dataContext;
        public PedidoRepository(DataContext context)
        {
            _dataContext = context;
        }

        public IEnumerable<Pedido> GetPedidos()
        {
            var pedidos = _dataContext.Pedido.ToList();
            return pedidos;
        }

        public Pedido GetPedido(int pedidoId)
        {
            var pedido = _dataContext.Pedido.Find(pedidoId);
            return pedido;
        }

        public int AddPedido(Pedido pedido)
        {
            _dataContext.Pedido.Add(pedido);
            _dataContext.SaveChanges();
            int id = pedido.PedidoId;
            return id;
        }

        public Pedido UpdatePedido(Pedido pedido)
        {
            var ret = _dataContext.Pedido.Find(pedido.PedidoId);
            if (ret != null)
            {
                ret.EmailCliente = pedido.EmailCliente;
                ret.NomeCliente = pedido.NomeCliente;
                ret.Pago = pedido.Pago;
                _dataContext.SaveChanges();
            }
            return ret;
        }
        public void DeletePedido(int pedidoId)
        {
            var ret = _dataContext.Pedido.Find(pedidoId);
            if(ret != null)
            {
                _dataContext.Pedido.Remove(ret);
                _dataContext.SaveChanges();
            }
        }

    }
}
