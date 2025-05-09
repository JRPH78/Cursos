using Microsoft.AspNetCore.Mvc;
using Muebleria.Server.Models;
using Muebleria.Server.Services;

namespace Muebleria.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class CatalogoController:ControllerBase
    {
        private readonly ICatalogoService _catalogoService;

        public CatalogoController(ICatalogoService catalogoService)
        {
            _catalogoService = catalogoService;
        }

        [HttpPost("PostCatalogo")]
        public async Task<IActionResult> Post(CatalogoCreateModel requestModel)
        {
            return StatusCode(201, await _catalogoService.CreateCatalogoAsync(requestModel));
        }
        [HttpGet("GetCatalogo")]
        public async Task<IActionResult> Get()
        {
            return StatusCode(200, await _catalogoService.GetAllCatalogosAsync());
        }

        [HttpGet("GetCatalogoById")]
        public async Task<IActionResult> GetCatalogoByIdAsync( int catalogoId)
        {
            return StatusCode(200, await _catalogoService.GetCatalogoByIdAsync(catalogoId));
        }
        [HttpPut("PutCatalogo")]
        public async Task<IActionResult> PutCatalogoAsync([FromBody] CatalogoCreateModel requestModel, int catalogoId)
        {
            return StatusCode(200, await _catalogoService.PutCatalogoAsync(catalogoId,requestModel));

        }

        [HttpDelete("DeleteCatalogo")]
        public async Task<IActionResult> DeleteCatalogo( int catalogoId)
        {
            await _catalogoService.DeleteCatalogoAsync(catalogoId);
            return StatusCode(200);

        }


    }
}
