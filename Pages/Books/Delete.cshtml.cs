using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Puscas_Andrei_Ioan_Laborator2.Data;
using Puscas_Andrei_Ioan_Laborator2.Models;

namespace Puscas_Andrei_Ioan_Laborator2.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly Puscas_Andrei_Ioan_Laborator2.Data.Puscas_Andrei_Ioan_Laborator2Context _context;

        public DeleteModel(Puscas_Andrei_Ioan_Laborator2.Data.Puscas_Andrei_Ioan_Laborator2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Book Book { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }

            var book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (book == null)
            {
                return NotFound();
            }
            else 
            {
                Book = book;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Book == null)
            {
                return NotFound();
            }
            var book = await _context.Book.FindAsync(id);

            if (book != null)
            {
                Book = book;
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
