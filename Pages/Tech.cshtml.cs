using Microsoft.AspNetCore.Mvc.RazorPages;
namespace R_CV.Pages;
public class TechModel : PageModel{
    private readonly ILogger<IndexModel> _logger;
    public TechModel(ILogger<IndexModel> logger){_logger = logger;}
    public void OnGet(){}
}