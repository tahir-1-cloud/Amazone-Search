using Microsoft.AspNetCore.Mvc;

namespace AmazonSearch.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();

        }
        public IActionResult Login()
        {

            return RedirectToAction("Index", "FinesCoper");
        }
    }
}
