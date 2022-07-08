using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaShop.Pages;

[BindProperties(SupportsGet = true)]
public class CheckoutModel : PageModel
{

    public string PizzaName { get; set; }
    public string PizzaPrice { get; set; }
    public string ImageTitle { get; set; }

    public void OnGet()
    {
        if (string.IsNullOrWhiteSpace(PizzaName))
        {
            PizzaName = "Custom";
        }
        if (string.IsNullOrWhiteSpace(ImageTitle))
        {
            ImageTitle = "Create";
        }
    }
}