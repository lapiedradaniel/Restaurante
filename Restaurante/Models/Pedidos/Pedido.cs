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
        public Pratos Pratos { get; set; }

        [Required]
        public Bebidas Bebida { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public Mesas Mesa { get; set; }

        [Required]
        public string? NomeSolicitante { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;

        public StatusPedido Status { get; set; } 
    }
}
