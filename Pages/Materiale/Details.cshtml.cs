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
    public class DetailsModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public DetailsModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

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
    }
}
