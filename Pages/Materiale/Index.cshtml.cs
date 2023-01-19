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
    public class IndexModel : PageModel
    {
        private readonly Magazin.Data.MagazinContext _context;

        public IndexModel(Magazin.Data.MagazinContext context)
        {
            _context = context;
        }

        public IList<Material> Material { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Material != null)
            {
                Material = await _context.Material.ToListAsync();
            }
        }
    }
}
