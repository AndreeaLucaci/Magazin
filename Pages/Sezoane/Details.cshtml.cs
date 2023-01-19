using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazin.Data;
using Magazin.Models;

namespace Magazin.Pages.Sezoane
{
    public class DetailsModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public DetailsModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

      public Sezon Sezon { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sezon == null)
            {
                return NotFound();
            }

            var sezon = await _context.Sezon.FirstOrDefaultAsync(m => m.ID == id);
            if (sezon == null)
            {
                return NotFound();
            }
            else 
            {
                Sezon = sezon;
            }
            return Page();
        }
    }
}
