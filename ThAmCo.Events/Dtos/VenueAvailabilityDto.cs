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

        public VenueAvailabilityDto(string code, string name, string description, int capacity, DateTime date, double costPerHour)
        {
            Code = code;
            Name = name;
            Description = description;
            Capacity = capacity;
            Date = date;
            CostPerHour = costPerHour;
        }
    }
}
