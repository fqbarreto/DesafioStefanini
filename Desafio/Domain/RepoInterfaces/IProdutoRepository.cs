using Desafio.Infra.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Domain.RepoInterfaces
{
    public interface IProdutoRepository
    {
        public IEnumerable<Produto> GetProdutos();
        public Produto GetProduto(int id);

    }
}
