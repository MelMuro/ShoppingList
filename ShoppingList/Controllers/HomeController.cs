using Microsoft.AspNetCore.Mvc;

namespace ShoppingList.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello world";
        }
    }
}