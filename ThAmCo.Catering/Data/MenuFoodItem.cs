using System.Security.Cryptography.X509Certificates;

namespace ThAmCo.Catering.Data
{
    public class MenuFoodItem
    {
        public int MenuId { get; set; }
        public int FoodItemId { get; set; }

        public FoodItem? FoodItem { get; set; }
        public Menu? Menu { get; set; }

        public MenuFoodItem()
        {

        }

        public MenuFoodItem(int menuId, int foodItemId)
        {
            MenuId = menuId;
            FoodItemId = foodItemId;
        }
    }
}
