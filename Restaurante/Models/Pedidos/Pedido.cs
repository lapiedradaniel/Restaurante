using Restaurante.Enums.Bebida;
using Restaurante.Enums.Mesa;
using Restaurante.Enums.StatusPedido;
using Restaurante.Enums.Prato;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models.Pedidos
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        [Required]
        public string? Pratos { get; set; }

        [Required]
        public int QuantidadePratos { get; set; }

        [Required]
        public string? Bebida { get; set; }

        [Required]
        public int QuantidadeBebidas { get; set; }

        [Required]
        public string? Mesa { get; set; }

        [Required]
        public string? NomeSolicitante { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;

        public string? Status { get; set; } 
    }
}
