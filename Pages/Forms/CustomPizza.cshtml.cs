using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaShop.Pages.Forms;

public class CustomPizzaModel : PageModel
{
    [BindProperty]
    public PizzasModel Pizza { get; set; }
    public float PizzaPrice { get; set; }
    public void OnGet()
    {
    }

    public IActionResult OnPost()
    {
        PizzaPrice = Pizza.BasePrice;
        if (Pizza.TomatoSauce) { ++PizzaPrice; }
        if (Pizza.Cheese) { ++PizzaPrice; }
        if (Pizza.Beef) { PizzaPrice += 3; }
        if (Pizza.Pineapple) { PizzaPrice += 2; }
        if (Pizza.Peperoni) { PizzaPrice += 4; }
        if (Pizza.Tuna) { PizzaPrice += 9; }
        if (Pizza.Ham) { PizzaPrice += 2; }

        return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
    }
}