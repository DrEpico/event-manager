namespace ThAmCo.Events.Data
{
    public class Staffing
    {
        //I dont know if taking the ? out would break update-database
        //-again so I will leave it just in case...
        public int? StaffingId { get; set; }
        public int StaffId {  get; set; }
        public int EventId { get; set; }

        // Navigation Properties
        public Staff Staff { get; set; }
        public Event Event { get; set; }
    }
}
