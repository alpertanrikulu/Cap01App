using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cap01App.Models;

namespace Cap01App.Pages.CariHesaplar
{
    public class DeleteModel : PageModel
    {
        private readonly Cap01App.Models.SLeaderDemoContext _context;

        public DeleteModel(Cap01App.Models.SLeaderDemoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public CarilerT CarilerT { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.CarilerTs == null)
            {
                return NotFound();
            }

            var carilert = await _context.CarilerTs.FirstOrDefaultAsync(m => m.Id == id);

            if (carilert == null)
            {
                return NotFound();
            }
            else 
            {
                CarilerT = carilert;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.CarilerTs == null)
            {
                return NotFound();
            }
            var carilert = await _context.CarilerTs.FindAsync(id);

            if (carilert != null)
            {
                CarilerT = carilert;
                _context.CarilerTs.Remove(CarilerT);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
