using Desafio.Domain.ServicesInterfaces;
using Desafio.Infra.Database;
using Desafio.Infra.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IProdutoService _produtoService;
        public ProdutoController(DataContext context, IProdutoService produtoService)
        {
            _dataContext = context;
            _produtoService = produtoService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetProdutos()
        {
            var produtos = _produtoService.GetProdutos().ToList();
            return produtos;
        }
    }
}
