using Microsoft.AspNetCore.Mvc;

namespace StockMarket.Controllers
{
    public class StockControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string[] Get()
        {
            return new string[]
            {
        "Hello",
        "World"
            };
        }
    }
}
