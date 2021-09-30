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
    public class DeleteModel : PageModel
    {
        private readonly colourContext _context;

        public DeleteModel(colourContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Program1 Program1 { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Program1 = await _context.Program1.FirstOrDefaultAsync(m => m.ID == id);

            if (Program1 == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Program1 = await _context.Program1.FindAsync(id);

            if (Program1 != null)
            {
                _context.Program1.Remove(Program1);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
