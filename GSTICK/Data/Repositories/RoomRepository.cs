﻿using GSTICK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Data.Repositories
{
    public class RoomRepository : GenericRepository<Room>
    {
        public RoomRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
