using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Services.Copa;

namespace Restaurante.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PedidoCopaController : Controller
    {
        private readonly CopaService _pedidoCopaService;
        public PedidoCopaController(CopaService pedidoCopaService)
        {
            _pedidoCopaService = pedidoCopaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var pedidoscopa = _pedidoCopaService.ListarPedidosCopa();

            return View(pedidoscopa);
            
        }
    }
}
