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
