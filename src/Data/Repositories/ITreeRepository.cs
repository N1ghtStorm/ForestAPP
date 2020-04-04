using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public interface ITreeRepository
    {
        Task<Tree> CreateTreeAsync(Tree tree);

        Task<Tree> GetTreeAsync(int id);

        Task<List<Tree>> GetTreesAsync();

        Task DeleteTreeAsync(int id);

        Task<Tree> UpdateTreeAsync(Tree tree);
    }
}
