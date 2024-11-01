using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Data
{
    public class Menu
    {
        public int MenuId { get; set; }
        [Required]
        public string MenuName { get; set; }

        public List<MenuFoodItem>? MenuFoodItems { get; set; }
        public FoodBooking? FoodBooking { get; set; }
       
        public Menu()
        {
            MenuName = string.Empty;
        }

        public Menu(int menuId, string menuName)
        {
            MenuId = menuId;
            MenuName = menuName;
        }
    }
}
