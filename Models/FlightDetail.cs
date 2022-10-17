using System;
using System.Collections.Generic;

namespace DhanmayaAirlines.Models
{
    public partial class FlightDetail
    {
        public int FlightId { get; set; }
        public string? FlightName { get; set; }
        public string? AirlinesName { get; set; }
        public string? Enginetype { get; set; }
    }
}
