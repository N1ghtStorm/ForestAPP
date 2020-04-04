using Data.Repositories;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ForestService : IForestService
    {
        private readonly IForestRepository _forestRepository;

        public ForestService(IForestRepository forestRepository)
        {
            _forestRepository = forestRepository;
        }

        public async Task<Forest> CreateForestAsync(Forest forest)
        {
            return await _forestRepository.CreateForestAsync(forest);
        }
    }
}
