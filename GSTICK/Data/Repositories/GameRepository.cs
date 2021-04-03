using GSTICK.Interfaces;
using GSTICK.Models;
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
    }
}
