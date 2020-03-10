using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Dojo
{
    public class StatisticsCalculator
    {
        public static int NombreEmployeeRDV()
        {
            using (var context = new Context())
            {
                var nbEmployees = from e in context.Persons
                                  where e.Appointments.Count > 0
                                  select e;
                var employeesList = from appointment in context.AppointmentPeople
                                    group appointment by appointment.Person.PersonId into appointmentGroup
                                    select appointmentGroup.Count();
                var groupedEmployees = employeesList.ToList();
                return nbEmployees.Count();
            }
        }
    }
}