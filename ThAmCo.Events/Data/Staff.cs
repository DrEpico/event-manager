namespace ThAmCo.Events.Data
{
    public class Staff
    {
        public int StaffId { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        // Navigation Properties
        public List<Staffing> Staffings { get; set; } = new();
    }
}
