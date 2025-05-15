using PetShopApp.Models;

namespace PetShopApp.ViewModels
{
    public class CartItemViewModel
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
