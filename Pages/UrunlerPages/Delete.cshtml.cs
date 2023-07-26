using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cap01App.Models;

namespace Cap01App.Pages.UrunlerPages
{
    public class DeleteModel : PageModel
    {
        private readonly Cap01App.Models.SLeaderDemoContext _context;

        public DeleteModel(Cap01App.Models.SLeaderDemoContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Urunler Urunler { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Urunlers == null)
            {
                return NotFound();
            }

            var urunler = await _context.Urunlers.FirstOrDefaultAsync(m => m.Id == id);

            if (urunler == null)
            {
                return NotFound();
            }
            else 
            {
                Urunler = urunler;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Urunlers == null)
            {
                return NotFound();
            }
            var urunler = await _context.Urunlers.FindAsync(id);

            if (urunler != null)
            {
                Urunler = urunler;
                _context.Urunlers.Remove(Urunler);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
