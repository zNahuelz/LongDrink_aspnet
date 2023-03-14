using Microsoft.AspNetCore.Mvc;

namespace LongDrink_aspnet.Controllers
{
    public class CursosPublicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
