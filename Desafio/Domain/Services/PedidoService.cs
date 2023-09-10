using Desafio.Application.Requests;
using Desafio.Application.Responses;
using Desafio.Domain.RepoInterfaces;
using Desafio.Domain.ServicesInterfaces;
using Desafio.Infra.Database.Models;
using System.Net;

namespace Desafio.Domain.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IItensPedidoRepository _itensPedidoRepository;

        public PedidoService(IProdutoRepository produtoRepository, IPedidoRepository pedidoRepository, IItensPedidoRepository itensPedidoRepository)
        {
            _produtoRepository = produtoRepository;
            _pedidoRepository = pedidoRepository;
            _itensPedidoRepository= itensPedidoRepository;
        }

        public IEnumerable<PedidoResponse> GetPedidos()
        {
            var ret = _pedidoRepository.GetPedidos();
            List<PedidoResponse> li = new List<PedidoResponse>();
            foreach (var p in ret)
            {
                var response = GetPedido(p.PedidoId);
                li.Add(response);
            }
            return li;
        }
        public PedidoResponse GetPedido(int pedidoId)
        {   
            PedidoResponse newResponse = new PedidoResponse();
            var pedido = _pedidoRepository.GetPedido(pedidoId);
            newResponse.nomeCliente = pedido.NomeCliente;
            newResponse.emailCliente = pedido.EmailCliente;
            newResponse.pago = pedido.Pago;
            var itens = _itensPedidoRepository.GetItensPedidoPorIdPedido(pedidoId);
            if(itens.Count() > 0)
            {
                foreach (var item in itens)
                {
                    var produto = _produtoRepository.GetProduto(item.ProdutoId);
                    PedidoResponse.itens itemPedidoUn = new PedidoResponse.itens(item.ItensPedidoId, produto.ProdutoId, produto.NomeProduto, produto.Valor, item.Quantidade);
                    newResponse.itensPedido.Add(itemPedidoUn);
                    newResponse.valorTotal += item.Quantidade * produto.Valor;
                }
            }
            return newResponse;
        }
        public void NovoUpdatePedido(NovoPedidoRequest pedidoRequest)
        {
            try
            {
                if(pedidoRequest.Id == 0)
                {
                    Pedido novoPedido = new Pedido(pedidoRequest.NomeCliente, pedidoRequest.EmailCliente, DateTime.Now, pedidoRequest.Pago);
                    var idPedido = _pedidoRepository.AddPedido(novoPedido);
                    foreach (var item in pedidoRequest.ItensDoPedido)
                    {
                        ItensPedido novo = new ItensPedido(item.IdProduto, idPedido, item.Quantidade);
                        var idItensPedido = _itensPedidoRepository.AddItensPedido(novo);
                    }
                }
                else
                {
                    Pedido novoPedido = new Pedido(pedidoRequest.NomeCliente, pedidoRequest.EmailCliente, pedidoRequest.Pago, pedidoRequest.Id);
                    var idPedido = _pedidoRepository.UpdatePedido(novoPedido);
                }
            } catch (Exception ex)
            {
                throw(ex);
            }
        }
        public void DeletePedido(int id)
        {
            try
            {
                _pedidoRepository.DeletePedido(id);

            }catch (Exception ex)
            {
                throw (ex);
            }
        }
    }
}
