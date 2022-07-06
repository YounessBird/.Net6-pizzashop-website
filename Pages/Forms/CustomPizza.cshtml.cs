using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaShop.Pages.Forms;

public class CustomPizzaModel : PageModel
{
    [BindProperty]
    public PizzasModel Pizza { get; set; }

    public void OnGet()
    {
    }
}