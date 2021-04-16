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
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace GSTICK.Pages.Games
{
    public class GamesModel : PageModel
    {
        private readonly IUnitOfWork _context;

        public GamesModel(IUnitOfWork context)
        {
            _context = context;
        }

        public IList<Game> Games { get;set; }
        public IList<Category> Categories { get; set; }

        public async Task OnGetAsync()
        {
            Games = await _context.Games.GetGamesWithImagesAsync();
            Categories = await _context.Categories.GetCategoriesGamesAsync();   
        }

        public async Task<PartialViewResult> OnGetGameDetails(int? id)
        {
            return new PartialViewResult
            {
                ViewName = "GameDetailsPartial",
                ViewData = new ViewDataDictionary<Game>(ViewData, await _context.Games.GetGameWithImageByIdAsync(id))
            };
        }
    }
}
