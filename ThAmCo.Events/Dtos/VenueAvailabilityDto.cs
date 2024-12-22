namespace ThAmCo.Events.Dtos
{
    public class VenueAvailabilityDto
    {
        public string Code { get; init; }
        public string Name { get; init; }
        public string Description { get; init; }
        public int Capacity { get; init; }
        public DateTime Date { get; init; }
        public double CostPerHour { get; init; }
    }
}
