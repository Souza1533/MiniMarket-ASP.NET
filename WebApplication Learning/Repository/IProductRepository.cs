using WebApplication_Learning.Models;

namespace WebApplication_Learning.Repository
{
    public interface IProductRepository
    {
        ProductModel Add(ProductModel product);
        bool Delete(int id);
        ProductModel Update(ProductModel product);
        ProductModel GetId(int id);
        List<ProductModel> GetAll();
    }
}
