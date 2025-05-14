using PetShopApp.Models;

namespace PetShopApp.ViewModels
{
    public class HomeViewModel
    {
        public List<FoodCategory> FoodCategories { get; set; } = new List<FoodCategory>();
        public List<FoodProduct> FoodProducts { get; set; } = new List<FoodProduct>();
    }
}
