using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Restaurante.Context;
using Restaurante.Enums.Bebida;
using Restaurante.Enums.Prato;
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
            pedido.Pratos = pedido.Pratos.ToString();
            pedido.Bebida = pedido.Bebida.ToString();
            pedido.Mesa = pedido.Mesa.ToString();
            pedido.Status = StatusPedido.Pendente.ToString();
            _context.Pedido.Add(pedido);
            await _context.SaveChangesAsync(); 

            await _cozinhaService.CriarPedidoCozinha(new PedidoCozinha
            {
                PedidoId = pedido.PedidoId, 
                DataHora = DateTime.Now,
                Status = pedido.Status.ToString(),
                Pedido = pedido
            });

            await _copaService.CriarPedidoCopa(new PedidoCopa
            {
                PedidoId = pedido.PedidoId, 
                DataHora = DateTime.Now,
                Status = pedido.Status.ToString(),
                Pedido = pedido
            });


        }


    }
}
