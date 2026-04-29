using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using WebApplication_Learning.Models;

public class MarketModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "The Name field is required!.")]

    public string Description { get; set; } = string.Empty;

    // Relacionamento com Account (Opcional: inverso do 1:1)
    [JsonIgnore]
    public AccountModel? Account { get; set; }

    // Relacionamento 1:N com Products (Um mercado tem muitos produtos)
    public ICollection<ProductModel> Products { get; set; } = new List<ProductModel>();
}