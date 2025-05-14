using Microsoft.EntityFrameworkCore;
using PetShopApp.Models;

namespace PetShopApp.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<FoodCategory> FoodCategories { get; set; } = null!;
        public DbSet<FoodProduct> FoodProducts { get; set; } = null!;


    }
}
