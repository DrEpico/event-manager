using ThAmCo.Catering.Data;

namespace ThAmCo.Catering.Dtos

{
    public class MenuFoodItemDto
    {
        public string MenuName { get; set; }
        public string FoodItemDescription { get; set; }

        public MenuFoodItemDto(string name, string description)
        {
            MenuName = name;
            FoodItemDescription = description;
        }
    }
}
