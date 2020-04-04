using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class TreeRepository : RepositoryBase<Tree>, ITreeRepository
    {
        public Task<Tree> CreateTreeAsync(Tree tree)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTreeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tree> GetTreeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tree>> GetTreesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Tree> UpdateTreeAsync(Tree tree)
        {
            throw new NotImplementedException();
        }
    }
}
