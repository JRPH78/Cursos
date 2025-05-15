using System.Collections.Generic;
using System.Threading.Tasks;
using organigrama.Server.Data_Entities;

namespace organigrama.Server.Services
{
    public interface IOrganigramaService
    {
        Task<IEnumerable<OrganigramaEntity>> GetAllOrganigramaAsync();
    }
}
