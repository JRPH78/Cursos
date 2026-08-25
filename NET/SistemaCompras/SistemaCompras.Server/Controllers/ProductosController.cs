using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaCompras.Server.Services;

namespace SistemaCompras.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductosController : Controller
    {
        private readonly IProductosService _productosService;
        public ProductosController(
            IProductosService productosService
            )
        {
            _productosService = productosService;

        }

        [HttpGet("GetProducts")]
        public async Task<IActionResult> GetProducts(CancellationToken cancellation)
        {


        }
    }
}
