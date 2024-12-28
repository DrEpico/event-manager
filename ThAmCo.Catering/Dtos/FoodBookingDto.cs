using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace ThAmCo.Catering.Dtos
{
    // DTO for creating a booking!
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

    public class FoodBookingEditInputDto // I already don't like where this is going 😭
    {
        [Required]
        public int ClientReferenceId { get; set; }
        public int? NumberOfGuests { get; set; }
        public int? MenuId { get; set; }
    }

    public class FoodBookingOutputDto
    {
        public int ClientReferenceId { get; set; }
        public int NumberOfGuests { get; set; }
        public string? MenuName { get; set; }

        public FoodBookingOutputDto()
        {
        }

        public FoodBookingOutputDto(int clientReferenceId, int numberOfGuests, string? menuName)
        {
            ClientReferenceId = clientReferenceId;
            NumberOfGuests = numberOfGuests;
            MenuName = menuName;
        }
    }
}
