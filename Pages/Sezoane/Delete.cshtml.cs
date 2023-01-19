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
    public class DeleteModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public DeleteModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Sezon == null)
            {
                return NotFound();
            }
            var sezon = await _context.Sezon.FindAsync(id);

            if (sezon != null)
            {
                Sezon = sezon;
                _context.Sezon.Remove(Sezon);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
