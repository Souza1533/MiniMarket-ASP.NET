using Microsoft.AspNetCore.Mvc;
using WebApplication_Learning.Repository;

namespace WebApplication_Learning.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            var product = _productRepository.Delete(id);
            if (product != null)
                return RedirectToAction("MyMarket", "Market");

            return NotFound();
        }

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            _productRepository.Add(product);
            return RedirectToAction("MyMarket", "Market");

        }


    }
}
