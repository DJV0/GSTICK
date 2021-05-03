using GSTICK.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IGameRepository _gameRepository;
        private ICategoryRepository _categoryRepository;
        private ApplicationDbContext _context;

        public IGameRepository Games
        {
            get
            {
                return _gameRepository = _gameRepository ?? new GameRepository(_context);
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
            }
        }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChangesAsync();
        }
    }
}
