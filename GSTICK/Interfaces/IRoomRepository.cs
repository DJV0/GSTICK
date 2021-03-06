using GSTICK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Interfaces
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        Task<List<Room>> GetRoomsWithImagesAsync();
        Task<Room> GetRoomWithImagesByIdAsync(int? id);
    }
}
