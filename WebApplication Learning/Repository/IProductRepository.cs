using WebApplication_Learning.Models;

namespace WebApplication_Learning.Repository
{
    public interface IProductRepository
    {
        List<ProductModel> FindAll();
        ProductModel Add(ProductModel product);
    }
}
