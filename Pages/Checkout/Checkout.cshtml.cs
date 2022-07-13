using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaShop.Infrastracture;
using Stripe;

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
    public string TotalInPence { get; set; }
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
        long total = PizzaPrice * 100;
        TotalInPence = total.ToString();
    }
    public IActionResult OnPost(string stripeToken, string stripeEmail)
    {
        PizzaOrder pizzaOrder = new PizzaOrder();
        pizzaOrder.PizzaName = PizzaName;
        pizzaOrder.BasePrice = PizzaPrice;

        var optionsCustomer = new CustomerCreateOptions
        {
            Email = stripeEmail,
        };
        var serviceCustomer = new CustomerService();
        Customer customer = serviceCustomer.Create(optionsCustomer);
        var optionsCharge = new ChargeCreateOptions
        {
            Amount = PizzaPrice * 100,
            Currency = "GBP",
            Description = "Pizza",
            Source = stripeToken,
            ReceiptEmail = stripeEmail
        };
        var serviceCharge = new ChargeService();
        Charge charge = serviceCharge.Create(optionsCharge);

        // _context.PizzaOrders.Add(pizzaOrder);
        // _context.SaveChanges();

        if (charge.Status == "succeeded")
        {
            var AmountPaid = Convert.ToDecimal(charge.Amount) % 100 / 100 + (charge.Amount) / 100;
            var CustomerName = customer.Name;
            return RedirectToPage("/Checkout/Thankyou", new { AmountPaid, CustomerName });

        }
        else
        {
            return RedirectToPage("/Checkout/Thankyou");
        }
    }
}