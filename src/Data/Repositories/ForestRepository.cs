using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ForestRepository : RepositoryBase<Forest>, IForestRepository
    {
        private readonly ForestDbContext _dbContext;

        public ForestRepository(ForestDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Forest> CreateForestAsync(Forest forest)
        {
            return await InvokeQueryAsync(async () =>
            {
                await _dbContext.Forests.AddAsync(forest);
                await _dbContext.SaveChangesAsync();
                return forest;
            });
        }

        public Task DeleteForestsAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Forest> GetForestAsync(int id)
        {
            return await InvokeQueryAsync(async () =>
            {
                return await _dbContext.Forests.FirstOrDefaultAsync(x => x.Id == id);
            });
        }

        public async Task<List<Forest>> GetForestsAsync()
        {
            return await InvokeQueryAsync(async () =>
            {
                return await _dbContext.Forests.ToListAsync();
            });
        }

        public Task<Forest> UpdateForestAsync(Forest forest, int id)
        {
            throw new NotImplementedException();
        }
    }
}
