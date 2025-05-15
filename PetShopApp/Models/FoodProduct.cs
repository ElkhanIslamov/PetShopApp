using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopApp.Models
{
    public class FoodProduct
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }
        public int FoodCategoryId { get; set; }
        public FoodCategory FoodCategory { get; set; } = null!;
    }
}
