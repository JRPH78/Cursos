using SistemaCompras.Server.Services;
using SistemaCompras.Server.Services.Implementations;

namespace SistemaCompras.Server
{
    public static class AppServices
    {
        public static void AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IProductosService, ProductosService>();
        }
    }
}
