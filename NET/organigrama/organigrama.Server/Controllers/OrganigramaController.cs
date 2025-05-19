using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using organigrama.Server.Services;


namespace organigrama.Server.Controllers
{
    public class OrganigramaController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IOrganigramaService _OrganigramaService;
        public OrganigramaController(IOrganigramaService OrganigramaService, IConfiguration configuration)
        {
            _OrganigramaService = OrganigramaService;
            Configuration = configuration;
        }


        [HttpGet]
        public async Task<IActionResult> GetOrganigrama()
        {
            return StatusCode(200, await _OrganigramaService.GetAllOrganigramaAsync());
        }
        public IActionResult Index()
        {
            return View();
        }



        [HttpGet("GetAllOrganigramaAsync")]
        public async Task<IActionResult> GetNombreBasesDeDatos()
        {
            var listaBases = new List<object>();

            // Asegúrate de tener esta cadena de conexión en tu appsettings.json
            var connectionString = Configuration.GetConnectionString("DataDbContext_Connection_Organigrama");

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                var command = new SqlCommand("SELECT * FROM dbo.VistaOrganigramaGerentes WHERE NivelFirma = 3", connection); // evita master, model, tempdb, msdb
                var reader = await command.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    listaBases.Add(new { id = reader.GetString(0), descripcion = reader.GetString(2), });
                }
            }

            return Ok(listaBases);
        }
    }
}
