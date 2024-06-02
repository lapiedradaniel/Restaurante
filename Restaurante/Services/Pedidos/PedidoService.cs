using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Restaurante.Context;
using Restaurante.Enums.StatusPedido;
using Restaurante.Models.Copa;
using Restaurante.Models.Cozinha;
using Restaurante.Models.Pedidos;
using Restaurante.Services.Copa;
using Restaurante.Services.Cozinha;

namespace Restaurante.Services.Pedidos
{
    public class PedidoService
    {
        private readonly AppDbContext _context;
        private readonly CozinhaService _cozinhaService;
        private readonly CopaService _copaService;

        

        public PedidoService(AppDbContext context, CozinhaService cozinhaService, CopaService copaService)
        {
            _context = context;
            _cozinhaService = cozinhaService;
            _copaService = copaService;
        }

        public async Task CriarPedido(Pedido pedido)
        {

            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync(); 

            await _cozinhaService.CriarPedidoCozinha(new PedidoCozinha
            {
                PedidoId = pedido.PedidoId, 
                DataHora = DateTime.Now,
                Status = StatusPedido.Pendente,
                Pedido = pedido
            });

            await _copaService.CriarPedidoCopa(new PedidoCopa
            {
                PedidoId = pedido.PedidoId, 
                DataHora = DateTime.Now,
                Status = StatusPedido.Pendente,
                Pedido = pedido
            });


        }


    }
}
