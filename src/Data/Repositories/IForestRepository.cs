using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface IForestRepository
    {
        Task<Forest> CreateForestAsync(Forest forest);

        Task<Forest> GetForestAsync(int id);

        Task<List<Forest>> GetForestsAsync();

        Task DeleteForestsAsync(int id);

        Task<Forest> UpdateForestAsync(Forest forest, int id);
    }
}
