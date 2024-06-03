using Restaurante.Enums.StatusPedido;
using Restaurante.Models.Pedidos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models.Cozinha
{
    [Table("PedidoCozinha")]
    public class PedidoCozinha
    {
        [Key]
        public int CozinhaId { get; set; }

        [Required]
        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }

        public Pedido? Pedido { get; set; }

        public string? Status { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;
    }
}
