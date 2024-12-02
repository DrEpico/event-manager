using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Dtos
{
    public class VenueReservationDto
    {
        [Required, DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        [Required, MinLength(5), MaxLength(5)]
        public string VenueCode { get; set; } = string.Empty;

        [Required]
        public string StaffId { get; set; }
    }
}
