using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo
{
    public class Appointment
    {
        public Guid AppointmentId { get; set; }
        public DateTime StrartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Room Room { get; set; }
    }
}
