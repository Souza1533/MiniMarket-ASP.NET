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
        public bool Delete(int id)
        {
            ProductModel product = GetId(id);

            if (product == null) throw new System.Exception("Produto nao encontrado");

            _appDbContext.Products.Remove(product);
            _appDbContext.SaveChanges();

            return true;
    
        }

        public ProductModel Update (ProductModel product)
        {
            ProductModel productDB = GetId(product.Id);

            productDB.Name = product.Name;
            productDB.Price = product.Price;

            _appDbContext.Products.Update(productDB);
            _appDbContext.SaveChanges();

            return productDB;
        }

        public ProductModel GetId(int id)
        {
            var product = _appDbContext.Products.Find(id);

            if (product == null) throw new System.Exception("Produto nao encontrado");

            return product;           
        }

        public List<ProductModel> GetAll()
        {
            return _appDbContext.Products.ToList();
        }

        

    }
}
