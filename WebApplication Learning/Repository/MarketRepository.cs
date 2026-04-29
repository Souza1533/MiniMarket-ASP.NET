using WebApplication_Learning.Data;

namespace WebApplication_Learning.Repository
{
    public class MarketRepository : IMarketRepository
    {
        private readonly AppDbContext _context;

        public MarketRepository(AppDbContext context)
        {
            _context = context;
        }

        public MarketModel Add(MarketModel market)
        {
            _context.Markets.Add(market);
            _context.SaveChanges();
            return market;

        }

        public bool Delete(int id)
        {
            MarketModel market = GetId(id);

            if (market == null) throw new Exception($"Market not found.");

            _context.Markets.Remove(market);
            _context.SaveChanges();

            return true;
        }

        public MarketModel Update (MarketModel market)
        {
            MarketModel marketDB = GetId(market.Id);

            marketDB.Name = market.Name;
            marketDB.Description = market.Description;

            _context.Markets.Update(marketDB);
            _context.SaveChanges();

            return marketDB;
        }

        public MarketModel GetId(int id)
        {
            var market = _context.Markets.Find(id);
            if (market == null) throw new Exception($"Market not found.");
            return market;
        }

        public List<MarketModel> GetAll()
        {
            return _context.Markets.ToList();
        }

    }
}
