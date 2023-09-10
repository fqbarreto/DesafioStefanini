using Desafio.Application.Requests;
using Desafio.Application.Responses;
using Desafio.Infra.Database.Models;

namespace Desafio.Domain.ServicesInterfaces
{
    public interface IPedidoService
    {
        public IEnumerable<PedidoResponse> GetPedidos();
        public void NovoUpdatePedido(NovoPedidoRequest pedidoRequest);
        public void DeletePedido(int id);
        public PedidoResponse GetPedido(int pedidoId);
    }
}
