using Desafio.Domain.RepoInterfaces;
using Desafio.Domain.ServicesInterfaces;
using Desafio.Infra.Database.Models;

namespace Desafio.Domain.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoService (IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> GetProdutos()
        {
            var ret = _produtoRepository.GetProdutos();
            return ret;
        }
    }
}
