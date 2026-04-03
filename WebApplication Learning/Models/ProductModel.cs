using System.Text.Json.Serialization;

public class ProductModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    // Chave estrangeira para Market
    public int? MarketId { get; set; }
    [JsonIgnore]
    public MarketModel? Market { get; set; }
}