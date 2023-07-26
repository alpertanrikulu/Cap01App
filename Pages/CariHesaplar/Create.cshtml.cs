using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Cap01App.Models;

namespace Cap01App.Pages.CariHesaplar
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
        public CarilerT CarilerT { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.CarilerTs == null || CarilerT == null)
            {
                return Page();
            }

            _context.CarilerTs.Add(CarilerT);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
