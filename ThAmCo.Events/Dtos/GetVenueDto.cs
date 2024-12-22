using System.ComponentModel.DataAnnotations;

namespace ThAmCo.Events.Dtos
{
    public class GetVenueDto
    {
        public string Reference { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }

        public string VenueCode { get; set; }

        // This is a computed property that returns the venue name based on the venue code.
        public string VenueName => VenueCode switch
        {
            "BLKTW" => "Blackthorn Workshop",
            "BRCHH" => "Birch Hall",
            "CMPGR" => "Competition Grounds",
            "CRKHL" => "Crackling Hall",
            "ELMRG" => "Elm Ridge Gardens",
            "FDLCK" => "The Fiddler's Cockatoo",
            "GLTNK" => "Glisten Tank",
            "HMSCR" => "HomeScape Cradle",
            "HNTWM" => "Huntwick Manor",
            "LNKRY" => "The Linkery",
            "MNSYN" => "Moonshine Inn",
            "RIVPT" => "Riverpoint Terrace",
            "SLTCR" => "Saltmarsh Retreat",
            "SPHRD" => "Sapphire Docks",
            "STGHM" => "Stargaze Hall",
            "STPFL" => "Stepfield Hall",
            "SUNPL" => "Sunset Pavilion",
            "TNDMR" => "Tinder Manor",
            "WDRSC" => "Woodrose Castle",
            "WTHTR" => "Willow Theatre",
            _ => "Unknown Venue"
        };

        public DateTime WhenMade { get; set; }

        public string StaffId { get; set; }
    }
}
