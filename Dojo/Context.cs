using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Dojo
{
    public class Context : DbContext
    {
        public DbSet<Person> Persons { get; set; } 
        public DbSet<AppointmentPerson> AppointmentPeople { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server = AG\SQLEXPRESS;Database = Dojoef6; Integrated Security=True");
        }
    }
}
