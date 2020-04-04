using Domain.Models;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface IForestService
    {
        Task<Forest> CreateForestAsync(Forest forest);
    }
}
