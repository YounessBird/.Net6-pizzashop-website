using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PizzaShop.Pages;

public class PizzaModel : PageModel
{
    public List<PizzasModel> fakePizzaDB = new List<PizzasModel>(){
        new PizzasModel(){ImageTitle="Margerita", PizzaName="Margerita", BasePrice=2, TomatoSauce=true, Cheese=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=4, TomatoSauce=true, Cheese=true,Peperoni=true, Beef=true, Ham=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=4, TomatoSauce=true, Cheese=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=3, TomatoSauce=true, Cheese=true, Peperoni=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="Seafood", PizzaName="Seafood", BasePrice=5, TomatoSauce=true, Cheese=true, Tuna=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="Vegetarian", PizzaName="Vegetarian", BasePrice=5, TomatoSauce=true, Cheese=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=7, TomatoSauce=true, Cheese=true,  Ham=true, Pineapple=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=9, TomatoSauce=true, Cheese=true, FinalPrice= 4},
        new PizzasModel(){ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=7, TomatoSauce=true, Cheese=true, Beef=true, FinalPrice= 4},
    };

    public void OnGet()
    {
    }
}
