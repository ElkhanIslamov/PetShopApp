namespace PetShopApp.Models
{
    public class FoodCategory
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<FoodProduct> FoodProducts { get; set; } = new List<FoodProduct>();

    }
}
