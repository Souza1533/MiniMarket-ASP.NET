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
            var product = _productRepository.GetId(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(ProductModel product)
        {
            if (product.Id <= 0)
                return BadRequest();

            var id = product.Id;

            _productRepository.Delete(id);

            return RedirectToAction(nameof(MarketController.Index), "Market");
        }

        public IActionResult Edit(int id)
        {
            ProductModel product = _productRepository.GetId(id);
            return View(product);
        }


        [HttpPost]
        public IActionResult Edit(ProductModel product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            _productRepository.Update(product);
            return RedirectToAction(nameof(MarketController.Index), "Market");
        }

        public IActionResult Create()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            _productRepository.Add(product);
            return RedirectToAction("Index", "Market");
        }


    }
}
