using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Data;
namespace PizzaShop.Pages;

[BindProperties(SupportsGet = true)]
public class CheckoutModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public CheckoutModel(ApplicationDbContext context)
    {
        _context = context;
    }

    public string PizzaName { get; set; }
    public int PizzaPrice { get; set; }
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
    public IActionResult OnPost()
    {
        PizzaOrder pizzaOrder = new PizzaOrder();
        pizzaOrder.PizzaName = PizzaName;
        pizzaOrder.BasePrice = PizzaPrice;

        _context.PizzaOrders.Add(pizzaOrder);
        _context.SaveChanges();
        return RedirectToPage("/Checkout/Thankyou");
    }
}