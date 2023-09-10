using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace Desafio.Application.Responses
{
    public class PedidoResponse
    {
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string emailCliente { get; set; }
        public bool pago { get; set; } 
        public decimal valorTotal { get; set; }
        public List<itens> itensPedido { get; set; }
        public PedidoResponse()
        {
            itensPedido = new List<itens>();
        }
        public class itens
        {
            public itens(int id, int idProduto, string nomeProduto, decimal valorUnitario, int quantidade)
            {
                this.id = id;
                this.idProduto = idProduto;
                this.nomeProduto = nomeProduto;
                this.valorUnitario = valorUnitario;
                this.quantidade = quantidade;
            }
            public int id { get; set; }
            public int idProduto { get; set; }
            public string nomeProduto { get; set; }
            public decimal valorUnitario { get; set; }
            public int quantidade { get; set; }
        }
    }
}
