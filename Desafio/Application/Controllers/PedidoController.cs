using Desafio.Application.Requests;
using Desafio.Application.Responses;
using Desafio.Domain.RepoInterfaces;
using Desafio.Domain.ServicesInterfaces;
using Desafio.Infra.Database;
using Desafio.Infra.Database.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Application.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PedidoController : Controller
    {
        private readonly DataContext _dataContext;
        private readonly IPedidoService _pedidoService;
        public PedidoController(DataContext context, IPedidoService pedidoService)
        {
            _dataContext = context;
            _pedidoService = pedidoService;
        }
        [HttpGet]
        [Route("GetPedidos")]
        public ActionResult<IEnumerable<PedidoResponse>> GetPedidos()
        {
            var pedidos = _pedidoService.GetPedidos().ToList();
            return pedidos;
        }
        [HttpGet]
        [Route("GetPedido")]
        public ActionResult<PedidoResponse> GetPedido(int id)
        {
            var pedido = _pedidoService.GetPedido(id);
            return pedido;
        }
        [HttpPost]
        [Route("NovoUpdatePedido")]
        public bool NovoUpdatePedido(NovoPedidoRequest pedidoRequest)
        {
            _pedidoService.NovoUpdatePedido(pedidoRequest);
            return true;
        }
        [HttpDelete]
        [Route("DeletePedido")]
        public bool DeletePedido(int id)
        {
            _pedidoService.DeletePedido(id);
            return true;
        }
    }
}
