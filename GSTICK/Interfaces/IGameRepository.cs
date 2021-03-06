using GSTICK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Interfaces
{
    public interface IGameRepository : IGenericRepository<Game>
    {
        Task<List<Game>> GetGamesWithImagesAsync();
        Task<Game> GetGameWithImageByIdAsync(int? id);
    }
}
