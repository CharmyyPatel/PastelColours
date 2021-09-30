using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using colour.Models;

namespace pastel.Pages_Colours
{
    public class CreateModel : PageModel
    {
        private readonly colourContext _context;

        public CreateModel(colourContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Program1 Program1 { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Program1.Add(Program1);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
