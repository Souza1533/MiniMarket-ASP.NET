using Microsoft.AspNetCore.Mvc;
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
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult MyMarket()
        {
            List<ProductModel> products = _productRepository.FindAll();
            return View(products);
        }
    }
}
