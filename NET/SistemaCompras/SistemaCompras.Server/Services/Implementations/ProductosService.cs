using System.Data.Entity;

namespace SistemaCompras.Server.Services.Implementations
{
    public class ProductosService: IProductosService
    {
        private readonly DbContext dbContext
        public ProductosService()
        {
        }
    }
}
