using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Dtos
{
    public class FoodItemDto
    {
        [StringLength(50, MinimumLength = 3)]
        public string Description { get; set; } = string.Empty;
        [Range(0.25, 100)]
        public float UnitPrice { get; set; }
    }
}
