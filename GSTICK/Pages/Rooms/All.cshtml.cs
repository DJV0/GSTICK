using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GSTICK.Data;
using GSTICK.Models;
using GSTICK.Interfaces;

namespace GSTICK.Pages.Rooms
{
    public class RoomsModel : PageModel
    {
        private readonly IRoomRepository _context;

        public RoomsModel(IRoomRepository context)
        {
            _context = context;
        }

        public IList<Room> Room { get;set; }

        public async Task OnGetAsync()
        {
            Room = await _context.GetAllAsync();
        }
    }
}
