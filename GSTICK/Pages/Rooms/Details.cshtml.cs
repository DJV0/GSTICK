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
    public class DetailsModel : PageModel
    {
        private readonly IRoomRepository _context;

        public DetailsModel(IRoomRepository context)
        {
            _context = context;
        }

        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Room = await _context.GetRoomWithImagesByIdAsync(id);

            if (Room == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
