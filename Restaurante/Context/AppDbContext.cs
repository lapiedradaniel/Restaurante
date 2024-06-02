using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurante.Models.Copa;
using Restaurante.Models.Cozinha;
using Restaurante.Models.Pedidos;

namespace Restaurante.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<PedidoCopa> PedidoCopa { get; set; }
        public DbSet<PedidoCozinha> PedidoCozinha { get; set; }
        public DbSet<Pedido> Pedido { get; set;}






    }
}
