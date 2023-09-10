using Desafio.Infra.Database.Models;

namespace Desafio.Domain.ServicesInterfaces
{
    public interface IProdutoService
    {
        public IEnumerable<Produto> GetProdutos();
    }
}
