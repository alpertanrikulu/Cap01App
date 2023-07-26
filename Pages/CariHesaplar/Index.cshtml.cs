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
    public class IndexModel : PageModel
    {
        private readonly Cap01App.Models.SLeaderDemoContext _context;

        public IndexModel(Cap01App.Models.SLeaderDemoContext context)
        {
            _context = context;
        }

        public IList<CarilerT> CarilerT { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.CarilerTs != null)
            {
                CarilerT = await _context.CarilerTs.ToListAsync();
            }
        }
    }
}
