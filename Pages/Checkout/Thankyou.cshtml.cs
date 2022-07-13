using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaShop.Pages;
[BindProperties(SupportsGet = true)]
public class ThankyouModel : PageModel
{
    public string CustomerName { get; set; }
    public int AmountPaid { get; set; }
    public void OnGet()
    {

    }
}