using Data.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class TreeService : ITreeService
    {
        private readonly ITreeRepository _treeRepository;

        public TreeService(ITreeRepository treeRepository)
        {
            _treeRepository = treeRepository;
        }

        public async Task<Tree> CreateTreeAsync(Tree tree)
        {
            return await _treeRepository.CreateTreeAsync(tree);
        }
    }
}
