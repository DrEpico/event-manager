using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Dtos
{
    public class MenuInputDto
    {
        [StringLength(50, MinimumLength = 3)]
        public string MenuName { get; set; } = string.Empty;
    }

    //It's kinda gross having 2 classes in one file but... 🥲
    public class MenuOutputDto
    {
        public int MenuId { get; set; } 
        public string MenuName { get; set; } = string.Empty;

        public MenuOutputDto(int menuId, string menuName)
        {
            MenuId = menuId;
            MenuName = menuName ?? "Unnamed Menu"; //Handle possible null value
        }
    }
}
