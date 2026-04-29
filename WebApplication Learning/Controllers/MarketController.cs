using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using WebApplication_Learning.Repository;

namespace WebApplication_Learning.Controllers
{
    public class MarketController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IMarketRepository _marketRepository;
        public MarketController(IProductRepository productRepository, IMarketRepository marketRepository)
        {
            _productRepository = productRepository;
            _marketRepository = marketRepository;
        }

        // Criar um mercado e associar produtos a ele e a uma conta de usuário

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MarketModel market)
        {
            _marketRepository.Add(market);

            HttpContext.Session.SetString("MarketCreated", "true");

            return RedirectToAction(nameof(Index), "Market");
        }

        public IActionResult NotLogged() 
        { 
            return View();
        }

        public IActionResult Index()
        {
            var IsLoggedIn = HttpContext.Session.GetString("IsLoggedIn") == "true";
            var MarketCreated = HttpContext.Session.GetString("MarketCreated") == "true";

            if (!IsLoggedIn)
                return RedirectToAction(nameof(NotLogged), "Market");
            
            if (IsLoggedIn && !MarketCreated)
                return RedirectToAction(nameof(Create), "Market");

            List<ProductModel> products = _productRepository.GetAll();
            return View(products);
            
                
            

            
        }

    }
}
