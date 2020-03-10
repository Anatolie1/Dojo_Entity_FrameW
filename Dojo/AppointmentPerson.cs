using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo
{
    public class AppointmentPerson
    {
        public Guid AppointmentPersonId { get; set; }
        public Person Person { get; set; }
        public Appointment Appointment { get; set; }
    }
}
