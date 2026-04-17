using WebApplication_Learning.Models;

namespace WebApplication_Learning.Repository
{
    public interface IProductRepository
    {
        ProductModel Delete(int id);
        List<ProductModel> ShowAll();
        ProductModel Add(ProductModel product);
    }
}
