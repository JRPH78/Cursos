using Muebleria.Server.Models;

namespace Muebleria.Server.Services
{
    public interface ICatalogoService
    {
        Task<CatalogoViewModel> CreateCatalogoAsync(CatalogoCreateModel requestModel);
        Task DeleteCatalogoAsync(int catalogoId);
        Task<IEnumerable<CatalogoViewModel>> GetAllCatalogosAsync();
        Task<CatalogoViewModel> GetCatalogoByIdAsync(int catalogoId);
        Task<CatalogoViewModel> PutCatalogoAsync(int catalogoId, CatalogoCreateModel requestModel);
    }
}
