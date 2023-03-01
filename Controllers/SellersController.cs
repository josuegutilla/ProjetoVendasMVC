using Microsoft.AspNetCore.Mvc;
using VendasWebMvc.Models;
using VendasWebMvc.Models.ViewModels;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new SellerFormViewModel { Seller = seller };
                return View(viewModel);
            }
            _sellerServices.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
