using Microsoft.EntityFrameworkCore;
using Restaurante.Context;
using Restaurante.Models.Cozinha;

namespace Restaurante.Services.Cozinha
{
    public class CozinhaService
    {
        private readonly AppDbContext _context;

        public CozinhaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CriarPedidoCozinha(PedidoCozinha pedidoCozinha)
        {
            _context.PedidoCozinha.Add(pedidoCozinha);
            await _context.SaveChangesAsync();
        }

       public IEnumerable<PedidoCozinha> ListarPedidosCozinha()
        {
            return _context.PedidoCozinha.Include(c => c.Pedido).ToList();
        }

        



    }
}
