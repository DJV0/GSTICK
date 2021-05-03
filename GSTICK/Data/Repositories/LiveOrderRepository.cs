using GSTICK.Interfaces;
using GSTICK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GSTICK.Data.Repositories
{
    public class LiveOrderRepository : GenericRepository<LiveOrder>, ILiveOrderRepository
    {
        public LiveOrderRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
