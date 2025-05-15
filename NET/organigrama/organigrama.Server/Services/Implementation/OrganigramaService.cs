using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using organigrama.Server.Data_context;
using organigrama.Server.Data_Entities;
using organigrama.Server.Services;

namespace organigrama.Server.Implementation
{
    public class OrganigramaService : IOrganigramaService
    {
        private readonly OrganigramaDbContext _dbContextService;
        public OrganigramaService(OrganigramaDbContext dbContextService)
        {
            _dbContextService = dbContextService;
        }
        public async Task<IEnumerable<OrganigramaEntity>> GetAllOrganigramaAsync()
        {
           return await _dbContextService.Organigrama.ToListAsync();
        }

    }
}
