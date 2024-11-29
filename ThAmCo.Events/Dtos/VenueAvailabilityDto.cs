namespace ThAmCo.Events.Dtos
{
    public class VenueAvailabilityDto
    {
        public required string Code;
        public required string Name;
        public required string Description;
        public required int Capacity;
        public required DateTime Date;
        public required double CostPerHour;
    }
}
