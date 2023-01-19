using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Magazin.Data;
using Magazin.Models;

namespace Magazin.Pages.Sezoane
{
    public class EditModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public EditModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Sezon Sezon { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Sezon == null)
            {
                return NotFound();
            }

            var sezon =  await _context.Sezon.FirstOrDefaultAsync(m => m.ID == id);
            if (sezon == null)
            {
                return NotFound();
            }
            Sezon = sezon;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Sezon).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SezonExists(Sezon.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SezonExists(int id)
        {
          return _context.Sezon.Any(e => e.ID == id);
        }
    }
}
