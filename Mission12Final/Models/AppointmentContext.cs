using System;
using Microsoft.EntityFrameworkCore;

namespace Mission12Final.Models
{
    public class AppointmentContext : DbContext
    {
        // constructor
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {
        }

        public DbSet<AppointmentResponse> Appointments { get; set; }
    }
}
