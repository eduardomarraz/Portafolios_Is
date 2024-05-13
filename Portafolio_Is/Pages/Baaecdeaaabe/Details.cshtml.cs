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
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

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
    }
}
