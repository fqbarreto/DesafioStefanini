using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio.Infra.Database.Models
{
    [Table("ItensPedido")]
    public class ItensPedido
    {
        public ItensPedido(int produtoId, int pedidoId, int quantidade) 
        {
            this.ProdutoId= produtoId;
            this.PedidoId= pedidoId;
            this.Quantidade= quantidade;
        }
        [Key]
        public int ItensPedidoId { get; set; }
        [Required]
        public int ProdutoId { get; set; }
        [Required]
        public int PedidoId { get; set; }
        [Required]
        public int Quantidade { get; set; }

        public Pedido? Pedido { get; set; }
        public Produto? Produto { get; set; }

    }
}
