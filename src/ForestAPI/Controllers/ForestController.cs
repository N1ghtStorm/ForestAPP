using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.Services;
using System.Threading.Tasks;

namespace ForestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForestController : ExtendedApiController
    {
        private readonly IForestService _forestService;

        public ForestController(IForestService forestService)
        {
            _forestService = forestService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(ForestDTO forestDTO)
        {
            return await InvokeRequest(async () =>
            {
                var forest = await _forestService.CreateForestAsync(forestDTO);
                return Created("", forest);
            });             
        }
    }
}