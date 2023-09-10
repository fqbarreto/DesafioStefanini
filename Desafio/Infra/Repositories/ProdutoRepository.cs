using Desafio.Domain.RepoInterfaces;
using Desafio.Infra.Database;
using Desafio.Infra.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _dataContext;
        public ProdutoRepository(DataContext context)
        {
            _dataContext = context;
        }

        public IEnumerable<Produto> GetProdutos()
        {
            var produtos = _dataContext.Produto.ToList();
            return produtos;
        }
        public Produto GetProduto(int produtoId) 
        {
            var produto = _dataContext.Produto.Find(produtoId);
            return produto;
        }
    }
}
