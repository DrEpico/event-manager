using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Dtos
{
    public class FoodItemDto
    {
        [StringLength(50)]
        public string? Description { get; set; } = string.Empty;

        //Range is 0-100 to avoid negative values for the float.
        [Range(0, 100, ErrorMessage = "Above £100 for a dish is crazy.")]
        public float? UnitPrice { get; set; }
    }
}
