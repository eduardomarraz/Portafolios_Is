//Pages/CV.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace R_CV.Pages;
public class CVModel : PageModel{
    private readonly ILogger<CVModel> _logger;
    public CVModel(ILogger<CVModel> logger){_logger = logger;}
    public void OnGet(){}}