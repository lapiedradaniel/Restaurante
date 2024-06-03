using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Models.Pedidos;
using Restaurante.Services.Pedidos;

namespace Restaurante.Controllers
{
    [Authorize]
    public class PedidoController : Controller
    {
        private readonly PedidoService _pedidoService;

        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public IActionResult FazerPedido()
        {
            return View(new Pedido());
        }

        
        [HttpPost]
        public async Task<IActionResult> FazerPedido(Pedido model)
        {
            if (ModelState.IsValid)
            {
                
                await _pedidoService.CriarPedido(model);

                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }
    }
}
