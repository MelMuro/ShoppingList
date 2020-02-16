using Microsoft.AspNetCore.Mvc;
using ShoppingList.Models;
using ShoppingList.Models.ViewModels;
using System;

namespace ShoppingList.Controllers
{
    public class ShoppingListController: Controller
    {
        public IActionResult Index()
        {
            return View(new ShoppingListViewModel());
        }

        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CreateShoppingList(ShoppingListViewModel model) 
        {
            if (ModelState.IsValid)
            {
                //TODO: add methods to validate selecteddays format
                var daysArray = Array.ConvertAll(model.SelectedDays.Trim().Split(','), int.Parse);
                var dietCalendar = new DietCalendar(model.SelectedFile);
                var shoppingList = new Models.ShoppingList(dietCalendar, daysArray);

                return View(shoppingList); 
            }
            return View("Index");
        }
    }
}
