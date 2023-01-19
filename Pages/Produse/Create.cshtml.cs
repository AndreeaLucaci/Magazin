using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Magazin.Data;
using Magazin.Models;
using System.Security.Policy;

namespace Magazin.Pages.Produse
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
            ViewData["ProducatorID"] = new SelectList(_context.Set<Producator>(), "ID", "NumeProducator");
            ViewData["MaterialID"] = new SelectList(_context.Set<Material>(), "ID", "NumeMaterial");
            ViewData["SezonID"] = new SelectList(_context.Set<Sezon>(), "ID", "NumeSezon");
            return Page();
        }

        [BindProperty]
        public Produs Produs { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

            _context.Produs.Add(Produs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
