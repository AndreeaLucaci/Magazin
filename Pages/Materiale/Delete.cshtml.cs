using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazin.Data;
using Magazin.Models;

namespace Magazin.Pages.Materiale
{
    public class DeleteModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public DeleteModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Material Material { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Material == null)
            {
                return NotFound();
            }

            var material = await _context.Material.FirstOrDefaultAsync(m => m.ID == id);

            if (material == null)
            {
                return NotFound();
            }
            else 
            {
                Material = material;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Material == null)
            {
                return NotFound();
            }
            var material = await _context.Material.FindAsync(id);

            if (material != null)
            {
                Material = material;
                _context.Material.Remove(Material);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
