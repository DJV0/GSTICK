using GSTICK.Interfaces;
using GSTICK.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Data.Repositories
{
    public class RoomRepository : GenericRepository<Room>, IRoomRepository
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Task<List<Room>> GetRoomsWithImagesAsync()
        {
            return _context.Rooms.Include(r => r.Images).ToListAsync();
        }

        public Task<Room> GetRoomWithImagesByIdAsync(int? id)
        {
            if(id == null)
            {
                return null;
            }
            return _context.Rooms.Include(r => r.Images).FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
