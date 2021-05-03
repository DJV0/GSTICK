using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GSTICK.Data;
using GSTICK.Models;
using GSTICK.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GSTICK.Pages
{
    public class ContactsModel : PageModel
    {
        private readonly ILiveOrderRepository _context;

        public ContactsModel(ILiveOrderRepository context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Не указано имя")]
            [Display(Name = "Имя")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Не указан номер телефона")]
            [Phone]
            [DataType(DataType.PhoneNumber)]
            [Display(Name = "Номер телефона")]
            public string Phone { get; set; }
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task OnPostAsync()
        {
            LiveOrder liveOrder = new LiveOrder();
            if(await TryUpdateModelAsync<LiveOrder>(liveOrder,"Input",l => l.Name, l=> l.Phone))
            {
                liveOrder.DateTime = DateTime.Now;
                await _context.Add(liveOrder);
            }
        }
    }
}
