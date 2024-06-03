using Restaurante.Enums.StatusPedido;
using Restaurante.Models.Pedidos;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models.Copa
{
    [Table("PedidoCopa")]
    public class PedidoCopa
    {
        [Key]
        public int CopaId { get; set; }

        [Required]
        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }

        public Pedido? Pedido { get; set; }

        public string? Status { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;

    }
}
