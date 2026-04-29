namespace WebApplication_Learning.Repository
{
    public interface IMarketRepository
    {
        MarketModel Add(MarketModel market);
        bool Delete(int id);
        MarketModel Update(MarketModel market);
        MarketModel GetId(int id);
        List<MarketModel> GetAll();
    }
}
