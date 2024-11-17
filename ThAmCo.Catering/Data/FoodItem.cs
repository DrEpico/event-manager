﻿namespace ThAmCo.Catering.Data
{
    public class FoodItem
    {
        public int FoodItemId { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }

        public List<MenuFoodItem>? MenuFoodItems { get; set; }

        public FoodItem()
        {
            Description = string.Empty;
        }

        public FoodItem(int foodItemId, string description, float unitPrice)
        {
            FoodItemId = foodItemId;
            Description = description;
            UnitPrice = unitPrice;
        }

        public FoodItem(string description, float unitPrice)
        {
            Description = description;
            UnitPrice = unitPrice;
        }
    }
}
