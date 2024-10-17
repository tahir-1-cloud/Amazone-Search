using Microsoft.AspNetCore.Mvc;

namespace AmazonSearch.Controllers
{
    public class FinesCoperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProductDatabase()
        {
            return View();
        }
    }
}
