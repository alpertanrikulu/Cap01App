using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cap01App.Models;

namespace Cap01App.Pages.UrunlerPages
{
    public class CreateModel : PageModel
    {
        private readonly Cap01App.Models.SLeaderDemoContext _context;

        public CreateModel(Cap01App.Models.SLeaderDemoContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Urunler Urunler { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Urunlers == null || Urunler == null)
            {
                return Page();
            }

            _context.Urunlers.Add(Urunler);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
