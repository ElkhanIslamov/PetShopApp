using System.ComponentModel.DataAnnotations.Schema;

namespace PetShopApp.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotalPrice { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();


    }
}
