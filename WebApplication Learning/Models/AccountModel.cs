using System.ComponentModel.DataAnnotations;
using WebApplication_Learning.Models;

public class AccountModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "The Name field is required.")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "The Age field is required.")]
    public int Age { get; set; }

    // Relacionamento 1:1 com Market
    public int? MarketId { get; set; }
    public MarketModel? Market { get; set; }
}