using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public required string ImageUrl { get; set; }
        public CartItem Cart { get; set; } = new CartItem();
        public int CartId { get; set; }
    }
}
