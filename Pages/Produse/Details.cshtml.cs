using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Magazin.Data;
using Magazin.Models;

namespace Magazin.Pages.Produse
{
    public class DetailsModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public DetailsModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

      public Produs Produs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null || _context.Produs == null)
            {
                return NotFound();
            }

            var produs = await _context.Produs.FirstOrDefaultAsync(m => m.ID == id);
            if (produs == null)
            {
                return NotFound();
            }
            else 
            {
                Produs = produs;
            }
            return Page();
        }
    }
}
