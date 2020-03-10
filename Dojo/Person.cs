using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public String Name { get; set; }
        public DateTime Birth_Day { get; set; }
        public bool Is_Employe { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
