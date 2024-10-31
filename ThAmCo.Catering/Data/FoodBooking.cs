namespace ThAmCo.Catering.Data
{
    public class FoodBooking
    {
        public int FoodItemId { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }

        public FoodBooking()
        {
            Description = string.Empty;
        }

        public FoodBooking(int foodItemId, string description, int unitPrice)
        {
            FoodItemId = foodItemId;
            Description = description;
            UnitPrice = unitPrice;
        }
    }
}
