using System;
using System.Collections.Generic;

namespace DhanmayaAirlines.Models
{
    public partial class Registration
    {
        public int RegId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long? PhoneNumber { get; set; }
        public string? Password { get; set; }
    }
}
