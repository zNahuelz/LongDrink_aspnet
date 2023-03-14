using Microsoft.AspNetCore.Mvc;

namespace LongDrink_aspnet.Controllers
{
    public class NosotrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
