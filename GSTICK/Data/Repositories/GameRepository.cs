using GSTICK.Interfaces;
using GSTICK.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Data.Repositories
{
    public class GameRepository : GenericRepository<Game>, IGameRepository
    {
        public GameRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Task<List<Game>> GetGamesWithImagesAsync()
        {
            return _context.Games.Include(g => g.Images).ToListAsync();
        }

        public Task<Game> GetGameWithImageByIdAsync(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return _context.Games.Include(g => g.Images).FirstOrDefaultAsync(g => g.Id == id);
        }
    }
}
