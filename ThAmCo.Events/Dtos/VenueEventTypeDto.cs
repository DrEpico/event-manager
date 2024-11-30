namespace ThAmCo.Events.Dtos
{
    public class VenueEventTypeDto
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public VenueEventTypeDto(string id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
