using WebApplication_Learning.Models;

public class AccountModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    // Relacionamento 1:1 com Market
    public int? MarketId { get; set; }
    public MarketModel? Market { get; set; }
}