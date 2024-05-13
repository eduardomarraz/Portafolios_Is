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
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Contactos> Contactos { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Contactos = await _context.Contactos.ToListAsync();
        }
    }
}
