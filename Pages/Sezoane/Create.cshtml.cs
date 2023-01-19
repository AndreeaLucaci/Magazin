using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Magazin.Data;
using Magazin.Models;

namespace Magazin.Pages.Sezoane
{
    public class CreateModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public CreateModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Sezon Sezon { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Sezon.Add(Sezon);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
