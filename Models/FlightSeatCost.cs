using System;
using System.Collections.Generic;

namespace DhanmayaAirlines.Models
{
    public partial class FlightSeatCost
    {
        public int Fscid { get; set; }
        public int? Fasid { get; set; }
        public string? Cost { get; set; }
        public string? SeatType { get; set; }
    }
}
