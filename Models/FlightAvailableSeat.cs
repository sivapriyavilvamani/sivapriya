using System;
using System.Collections.Generic;

namespace DhanmayaAirlines.Models
{
    public partial class FlightAvailableSeat
    {
        public int Fasid { get; set; }
        public int? FlightId { get; set; }
        public string? SeatNo { get; set; }
        public string? Status { get; set; }
    }
}
