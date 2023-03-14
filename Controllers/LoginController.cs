using Microsoft.AspNetCore.Mvc;

namespace LongDrink_aspnet.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
