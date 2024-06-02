using Restaurante.Context;
using Restaurante.Models.Copa;

namespace Restaurante.Services.Copa
{
    public class CopaService
    {
        private readonly AppDbContext _context;

        public CopaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CriarPedidoCopa(PedidoCopa pedidoCopa)
        {

            _context.PedidoCopa.Add(pedidoCopa);
            await _context.SaveChangesAsync();
        }
    }
}
