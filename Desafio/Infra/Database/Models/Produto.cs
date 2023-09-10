using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio.Infra.Database.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }
        [Required]
        [StringLength(20)]
        public string? NomeProduto { get; set; }
        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Valor { get; set; }

    }
}
