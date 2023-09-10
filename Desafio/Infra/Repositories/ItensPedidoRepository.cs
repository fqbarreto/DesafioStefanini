using Desafio.Domain.RepoInterfaces;
using Desafio.Infra.Database;
using Desafio.Infra.Database.Models;

namespace Desafio.Infra.Repositories
{
    public class ItensPedidoRepository : IItensPedidoRepository
    {
        private readonly DataContext _dataContext;
        public ItensPedidoRepository(DataContext context)
        {
            _dataContext = context;
        }

        public int AddItensPedido(ItensPedido itensPedido)
        {
            if (itensPedido.ProdutoId != 0)
            {
                _dataContext.ItensPedido.Add(itensPedido);
                _dataContext.SaveChanges();
                int id = itensPedido.ItensPedidoId;
                return id;
            }
            return 0;
        }
        public IEnumerable<ItensPedido> GetItensPedidoPorIdPedido(int idPedido)
        {
            var itens = _dataContext.ItensPedido.Where(r => r.PedidoId == idPedido).ToList();
            return itens;
        }

    }
}
