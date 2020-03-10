using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace Dojo
{
    public class FactoryBD
    {
        public static void CreateDB()
        {
            Random randomGenerator = new Random();
            using (var context = new Context())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();


                for(int i = 1; i <= 3; i++)
                {
                    var address = new Address() { StreetName = $"Street{i}", StreetNumber = i, Zipcode = 10000 + i };
                    var structure = new Structure() { Address = address };
                    context.Add(address);
                    context.Add(structure);

                    for (int j = 1; j <= 3; j++)
                    {
                        var room = new Room() { Name = $"Room n° {j}", Structure = structure };
                        context.Add(room);

                        for (int rdv = 1; rdv <= 5; rdv++)
                        {
                            DateTime meeting = DateTime.Today.AddDays(randomGenerator.Next(1, 29));
                            DateTime pastMeeting = meeting - TimeSpan.FromDays(25);
                            var futurRdv = new Appointment() { StrartDate = meeting, EndDate = meeting + TimeSpan.FromHours(2), Room = room };
                            var pastRdv = new Appointment() { StrartDate = pastMeeting, EndDate = pastMeeting + TimeSpan.FromHours(2), Room = room };
                            context.Add(futurRdv);
                            context.Add(pastRdv);
                        }
                    }

                    context.SaveChanges();

                    for(int emp = 1; emp <= 5; emp ++)
                    {
                        var employee = new Person() { Name = $"Employee {emp}", Birth_Day = DateTime.Today, Is_Employe = true };
                        context.Add(employee);

                        var pastMeetings = (from app in context.Appointments
                                           where app.StrartDate < DateTime.Today
                                            select app).ToList();

                        var id = emp * i;

                        var pastAppointmentPerson = new AppointmentPerson() { Appointment = pastMeetings.ElementAt(id), Person = employee };

                        var futurMeetings = (from app in context.Appointments
                                            where app.StrartDate > DateTime.Today
                                            select app).ToList();

                        var futurAppointmentPerson = new AppointmentPerson() { Appointment = futurMeetings.ElementAt(id), Person = employee };

                        context.Add(pastAppointmentPerson);
                        context.Add(futurAppointmentPerson);
                    }
                }
                context.SaveChanges();
            }

        }
    }
}
