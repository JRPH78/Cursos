using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Muebleria.Server.Data_context;
using Muebleria.Server.Data_Entities;
using Muebleria.Server.Models;

namespace Muebleria.Server.Services.Implementation
{
    public class CatalogoService : ICatalogoService
    {
        private readonly MuebleriaDbContext _dbContextService;
        private readonly IMapper _mapperService;

        public CatalogoService(MuebleriaDbContext dbContextService, IMapper mapperService)
        {
            _dbContextService = dbContextService;
            _mapperService = mapperService;
        }

        public async Task<CatalogoViewModel> CreateCatalogoAsync(CatalogoCreateModel requestModel)
        {
            //CatalogoEntity catalogo=_mapperService.Map<CatalogoEntity>(requestModel);
            var catalogoNew = await _dbContextService.Catalogos.AddAsync(_mapperService.Map<CatalogoEntity>(requestModel));

            await _dbContextService.SaveChangesAsync();

            return _mapperService.Map<CatalogoViewModel>(catalogoNew.Entity);
        }

        public async Task<IEnumerable<CatalogoViewModel>> GetAllCatalogosAsync()
        {
            return _mapperService.Map<IEnumerable<CatalogoViewModel>>(await _dbContextService.Catalogos.ToListAsync());
        }
        public async Task<CatalogoViewModel> GetCatalogoByIdAsync(int catalogoId)
        {
            CatalogoEntity catalogo = await _dbContextService.Catalogos.FindAsync(catalogoId);

            return _mapperService.Map<CatalogoViewModel>(catalogo);

        }

        public async Task<CatalogoViewModel> PutCatalogoAsync(int catalogoId, CatalogoCreateModel requestModel)
        {
            CatalogoEntity catalogo = await _dbContextService.Catalogos.FindAsync(catalogoId);
            if (catalogo == null)
            {
                throw new ArgumentNullException(nameof(catalogo));

            }
            _mapperService.Map(requestModel, catalogo);
            await _dbContextService.SaveChangesAsync();

            return _mapperService.Map<CatalogoViewModel>(catalogo);

        }

         public async Task DeleteCatalogoAsync(int catalogoId)
        {
            var catalogo = await _dbContextService.Catalogos.FindAsync(catalogoId);
            if (catalogo == null)
            {
                throw new ArgumentNullException(nameof(catalogo));

            }
            _dbContextService.Catalogos.Remove(catalogo);
            await _dbContextService.SaveChangesAsync();



        }






    }
}
