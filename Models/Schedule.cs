using System;
using System.Collections.Generic;

namespace DhanmayaAirlines.Models
{
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime? Arrival { get; set; }
        public DateTime? Departure { get; set; }
        public string? Source { get; set; }
        public string? SourceTerminal { get; set; }
        public string? Destination { get; set; }
        public string? DestinamtionTerminal { get; set; }
    }
}
