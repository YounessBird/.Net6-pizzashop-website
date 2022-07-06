using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaShop.Pages;

public class ThankyouModel : PageModel
{
    private readonly ILogger<ThankyouModel> _logger;

    public ThankyouModel(ILogger<ThankyouModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}