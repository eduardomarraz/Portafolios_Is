using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using R_CV;

namespace R_CV.Pages_Baaecdeaaabe
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Contactos Contactos { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos.FirstOrDefaultAsync(m => m.Id == id);

            if (contactos == null)
            {
                return NotFound();
            }
            else
            {
                Contactos = contactos;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contactos = await _context.Contactos.FindAsync(id);
            if (contactos != null)
            {
                Contactos = contactos;
                _context.Contactos.Remove(Contactos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
