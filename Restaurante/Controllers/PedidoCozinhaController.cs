using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Services.Cozinha;


namespace Restaurante.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PedidoCozinhaController : Controller
    {
        private readonly CozinhaService _pedidoCozinhaService;

        public PedidoCozinhaController(CozinhaService pedidoCozinhaService)
        {
            _pedidoCozinhaService = pedidoCozinhaService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var pedidoscozinha = _pedidoCozinhaService.ListarPedidosCozinha();

            return View(pedidoscozinha);
        }
    }
}
