using Microsoft.EntityFrameworkCore;
using WebApplication_Learning.Models;

namespace WebApplication_Learning.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProductModel> Products { get; set; }
        public DbSet<MarketModel> Markets { get; set; }
        public DbSet<AccountModel> Accounts { get; set; }
    }
}
