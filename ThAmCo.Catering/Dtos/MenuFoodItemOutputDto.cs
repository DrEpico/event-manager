using ThAmCo.Catering.Data;

namespace ThAmCo.Catering.Dtos
{
    public class MenuFoodItemInputDto
    {   
        public int? MenuId { get; set; }
        public int? FoodItemId { get; set; }

        public MenuFoodItemInputDto(int menu, int foodItem)
        {
            MenuId = menu;
            FoodItemId = foodItem;
        }
    }

    public class MenuFoodItemOutputDto
    {
        public string MenuName { get; set; }
        public string FoodItemDescription { get; set; }

        public MenuFoodItemOutputDto(string name, string description)
        {
            MenuName = name;
            FoodItemDescription = description;
        }
    }
}
