using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Catering.Dtos
{
    public class FoodBookingInputDto
    {
        [Required] //Not nullable!
        [Range(1,100)]
        public int NumberOfGuests { get; set; }
        [Required] //Same as above
        public int MenuId { get; set; }

        public FoodBookingInputDto(int numberOfGuests, int menuId)
        {
            NumberOfGuests = numberOfGuests;
            MenuId = menuId;
        }
    }

    public class FoodBookingOutputDto
    {
        public int ClientReferenceId { get; set; }
        public int NumberOfGuests { get; set; }
        public string? MenuName { get; set; }

        public FoodBookingOutputDto(int clientReferenceId, int numberOfGuests, string? menuName)
        {
            ClientReferenceId = clientReferenceId;
            NumberOfGuests = numberOfGuests;
            MenuName = menuName;
        }
    }
}
