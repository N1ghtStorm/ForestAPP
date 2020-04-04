using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public interface ITreeService
    {
        Task<Tree> CreateTreeAsync(Tree tree);
    }
}
