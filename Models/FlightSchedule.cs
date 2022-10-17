using System;
using System.Collections.Generic;

namespace DhanmayaAirlines.Models
{
    public partial class FlightSchedule
    {
        public int Fsid { get; set; }
        public int? FlightId { get; set; }
        public int? ScheduleId { get; set; }
    }
}
