using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cap01App.Models;

namespace Cap01App.Pages.UrunlerPages
{
    public class EditModel : PageModel
    {
        private readonly Cap01App.Models.SLeaderDemoContext _context;

        public EditModel(Cap01App.Models.SLeaderDemoContext context)
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

            var urunler =  await _context.Urunlers.FirstOrDefaultAsync(m => m.Id == id);
            if (urunler == null)
            {
                return NotFound();
            }
            Urunler = urunler;
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

            _context.Attach(Urunler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UrunlerExists(Urunler.Id))
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

        private bool UrunlerExists(int id)
        {
          return (_context.Urunlers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
