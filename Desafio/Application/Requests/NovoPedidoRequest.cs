using Desafio.Infra.Database.Models;
using System.Collections;

namespace Desafio.Application.Requests
{
    public class NovoPedidoRequest
    {
        public int Id { get; set; }
        public string? NomeCliente { get; set; }
        public string? EmailCliente { get; set; }
        public bool Pago { get; set; }

        public ICollection<Itens> ItensDoPedido { get; set; }
        public class Itens
        {
            public int IdProduto { get; set; }
            public int Quantidade { get; set; }
        }
    }
}
