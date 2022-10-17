using System;
using System.Collections.Generic;

namespace DhanmayaAirlines.Models
{
    public partial class BookingDetail
    {
        public int BookingId { get; set; }
        public int? RegId { get; set; }
        public int? Fsid { get; set; }
        public int? Fasid { get; set; }
        public int? Fscid { get; set; }
    }
}
