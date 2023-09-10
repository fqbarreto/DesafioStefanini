using Desafio.Infra.Database.Models;
using Microsoft.AspNetCore.Mvc;


namespace Desafio.Domain.RepoInterfaces
{
    public interface IPedidoRepository
    {
        public IEnumerable<Pedido> GetPedidos();
        public int AddPedido(Pedido pedido);
        public Pedido UpdatePedido(Pedido pedido);
        public void DeletePedido(int pedidoId);
        public Pedido GetPedido(int pedidoId);
    }
}
