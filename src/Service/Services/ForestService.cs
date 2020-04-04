using AutoMapper;
using Data.Repositories;
using Domain.DTOs;
using Domain.Models;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ForestService : IForestService
    {
        private readonly IForestRepository _forestRepository;
        private readonly IMapper _mapper;

        public ForestService(IForestRepository forestRepository,
                             IMapper mapper)
        {
            _forestRepository = forestRepository;
            _mapper = mapper;
        }

        public async Task<ForestDTO> CreateForestAsync(ForestDTO forestDto)
        {
            var forest = _mapper.Map<Forest>(forestDto);
            forest = await _forestRepository.CreateForestAsync(forest);
            return _mapper.Map<ForestDTO>(forest);
        }
    }
}
