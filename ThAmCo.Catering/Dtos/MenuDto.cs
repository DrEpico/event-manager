using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Dtos
{
    public class MenuDto
    {
        [StringLength(50, MinimumLength = 3)]
        public string MenuName { get; set; } = string.Empty;
    }
}
