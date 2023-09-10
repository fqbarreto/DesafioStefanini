using Desafio.Infra.Database.Models;

namespace Desafio.Domain.RepoInterfaces
{
    public interface IItensPedidoRepository
    {
        public int AddItensPedido(ItensPedido itensPedido);
        public IEnumerable<ItensPedido> GetItensPedidoPorIdPedido(int idPedido);
    }
}
