using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Cap01App.Models;

namespace Cap01App.Pages.CariHesaplar
{
    public class EditModel : PageModel
    {
        private readonly Cap01App.Models.SLeaderDemoContext _context;

        public EditModel(Cap01App.Models.SLeaderDemoContext context)
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

            var carilert =  await _context.CarilerTs.FirstOrDefaultAsync(m => m.Id == id);
            if (carilert == null)
            {
                return NotFound();
            }
            CarilerT = carilert;
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

            _context.Attach(CarilerT).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarilerTExists(CarilerT.Id))
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

        private bool CarilerTExists(int id)
        {
          return (_context.CarilerTs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
