using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

public class ProductModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "The Name field is required!.")]
    public string? Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "The Price field is required!.")]
    public decimal Price { get; set; }

    // Chave estrangeira para Market
    public int? MarketId { get; set; }
    [JsonIgnore]
    public MarketModel? Market { get; set; }
}