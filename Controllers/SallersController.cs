using Microsoft.AspNetCore.Mvc;

namespace VendasWebMvc.Controllers
{
    public class SallersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
