using GSTICK.Interfaces;
using GSTICK.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Task<List<Category>> GetCategoriesGamesAsync()
        {
            return _context.Categories.Include(c => c.Games).ToListAsync();
        }
    }
}
