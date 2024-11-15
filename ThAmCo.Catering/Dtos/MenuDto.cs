using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Dtos
{
    public class MenuInputDto
    {
        [StringLength(50, MinimumLength = 3)]
        public string MenuName { get; set; } = string.Empty;
    }

    public class MenuOutputDto
    {
        public int MenuId { get; set; } 
        public string MenuName { get; set; } = string.Empty;

        public MenuOutputDto(int menuId, string menuName)
        {
            MenuId = menuId;
            MenuName = menuName;
        }
    }
}
