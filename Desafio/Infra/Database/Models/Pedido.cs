using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio.Infra.Database.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        public Pedido(string nomeCliente, string emailCliente, DateTime dataCriacao, bool pago)
        {
            this.NomeCliente= nomeCliente;
            this.EmailCliente= emailCliente;
            this.DataCriacao= dataCriacao;
            this.Pago= pago;
        }
        public Pedido(string nomeCliente, string emailCliente, bool pago, int pedidoId)
        {
            this.NomeCliente = nomeCliente;
            this.EmailCliente = emailCliente;
            this.Pago = pago;
            this.PedidoId = pedidoId;
        }
        public Pedido()
        {
            ItensPedidos = new Collection<ItensPedido>();
        }
        [Key]
        public int PedidoId { get; set; }
        [StringLength(60)]
        public string? NomeCliente { get; set; }
        [StringLength(60)]
        public string? EmailCliente { get; set; }

        public DateTime DataCriacao { get; set; }
        [Required]
        public bool Pago { get; set; }

        public ICollection<ItensPedido>? ItensPedidos { get; set; }
    }
}
