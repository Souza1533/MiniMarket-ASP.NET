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
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("IsLoggedIn") == "true")
            {
                return RedirectToAction("MyMarket", "Market");
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult MyMarket()
        {
            List<ProductModel> products = _productRepository.ShowAll();
            return View(products);
        }
    }
}
