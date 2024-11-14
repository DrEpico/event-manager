using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Dtos
{
    public class FoodItemDto
    {
        [StringLength(50, MinimumLength = 3)]
        public string? Description { get; set; } = string.Empty;
        [Range(0.25, 100, ErrorMessage = "Above £100 for a dish is crazy.")]
        public float? UnitPrice { get; set; }
    }
}
