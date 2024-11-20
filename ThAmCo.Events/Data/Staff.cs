namespace ThAmCo.Events.Data
{
    public class Staff
    {
        public int StaffId { get; set; } 
        public string Name { get; set; }
        public string Role { get; set; }

        // Navigation Properties
        public List<Staffing> Staffings { get; set; } = new();
    }
}
