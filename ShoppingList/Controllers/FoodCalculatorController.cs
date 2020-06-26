using Microsoft.AspNetCore.Mvc;
using ShoppingList.Models;
using ShoppingList.Models.ViewModels;

namespace ShoppingList.Controllers
{
    public class FoodCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new FoodCalculatorViewModel());
        }

        public IActionResult GetFoodEquivalence(FoodCalculatorViewModel model) 
        {
            if (ModelState.IsValid)
            {
                var foodCalculator = new FoodCalculator(model.FoodName, model.Quantity);
                return View(foodCalculator);
            }
            return View("Index");
        }
    }
}