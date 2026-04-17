using WebApplication_Learning.Data;
using WebApplication_Learning.Models;

namespace WebApplication_Learning.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }
        public ProductModel Add(ProductModel product)
        {
            _appDbContext.Add(product);
            _appDbContext.SaveChanges();

            return product;
        }

        public List<ProductModel> ShowAll()
        {
            return _appDbContext.Products.ToList();
        }

        public ProductModel Delete(int id)
        {
            var product = _appDbContext.Products.Find(id);
            if (product != null) { 
                _appDbContext.Products.Remove(product);
                _appDbContext.SaveChanges();
                return product;
            }
            else
            {
                return null;
            }
        }
    }
}
