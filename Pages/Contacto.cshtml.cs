//Pages/Contacto.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace R_CV;
public class ContactoModel : PageModel{
    private readonly AppDbContext _context;
    public ContactoModel(AppDbContext context){_context = context;}
    public IActionResult OnGet(){return Page();}
    [BindProperty]
    public Contactos Contactos { get; set; } = default!;
    public async Task<IActionResult> OnPostAsync(){
        if (!ModelState.IsValid){return Page();}
        _context.Contactos.Add(Contactos);
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");}}
