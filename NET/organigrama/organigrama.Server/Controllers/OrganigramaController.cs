using Microsoft.AspNetCore.Mvc;
using organigrama.Server.Services;


namespace organigrama.Server.Controllers
{
    public class OrganigramaController : Controller
    {
        private readonly IOrganigramaService _OrganigramaService;
        public OrganigramaController(IOrganigramaService OrganigramaService)
        {
            _OrganigramaService = OrganigramaService;
        }


        [HttpGet("GetAllOrganigramaAsync")]
        public async Task<IActionResult> GetOrganigrama()
        {
            return StatusCode(200, await _OrganigramaService.GetAllOrganigramaAsync());
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
