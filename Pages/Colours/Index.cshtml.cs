using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using colour.Models;

namespace pastel.Pages_Colours
{
    public class IndexModel : PageModel
    {
        private readonly colourContext _context;

        public IndexModel(colourContext context)
        {
            _context = context;
        }

        public IList<Program1> Program1 { get;set; }

        public async Task OnGetAsync()
        {
            Program1 = await _context.Program1.ToListAsync();
        }
    }
}
