using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Services;

namespace VendasWebMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerServices;

        public SellersController(SellerServices sellersServices)
        {
            _sellerServices = sellersServices;
        }

        public IActionResult Index()
        {
            var lista = _sellerServices.FindAll();
            return View(lista);
        }
    }
}
