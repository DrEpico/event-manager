﻿namespace ThAmCo.Events.Data
{
    public class Staffing
    {
        public int StaffingId { get; set; }
        public int StaffId {  get; set; }
        public int EventId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Navigation Properties
        public Staff Staff { get; set; }
        public Event Event { get; set; }
    }
}
