using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using PizzaShop.Data;
public class OrdersModel : PageModel
{
    private readonly ApplicationDbContext _context;
    public List<PizzaOrder> OrdersList = new List<PizzaOrder>();
    public OrdersModel(ApplicationDbContext context)
    {
        _context = context;
    }
    public void OnGet()
    {
        OrdersList = _context.PizzaOrders.ToList();
    }
}