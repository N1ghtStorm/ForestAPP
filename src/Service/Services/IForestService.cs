using Domain.DTOs;
using Domain.Models;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface IForestService
    {
        Task<ForestDTO> CreateForestAsync(ForestDTO forestDto);
    }
}
