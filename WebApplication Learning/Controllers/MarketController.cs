using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.NetworkInformation;
using WebApplication_Learning.Repository;

namespace WebApplication_Learning.Controllers
{
    public class MarketController : Controller
    {
        private readonly IProductRepository _productRepository;
        public MarketController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Criar um mercado e associar produtos a ele e a uma conta de usuário

        /*[HttpPost]
        public IActionResult Add(MarketModel market)
        {
            _marketRepository.Add(market);

            HttpContext.Session.SetString("IsLoggedIn", "true");

            return RedirectToAction("Index", "Market");
        }*/

        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") == "true")
            {
                List<ProductModel> products = _productRepository.GetAll();
                return View(products);
            }
        
            return View();    
        }

    }
}
