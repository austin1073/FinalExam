using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FinalExam.Models
{
    public class EntertainmentAgencyExampleContext : DbContext
    {
        public EntertainmentAgencyExampleContext()
        {
        }

        public EntertainmentAgencyExampleContext(DbContextOptions<EntertainmentAgencyExampleContext> options)
            : base(options)
        {
        }

        public  DbSet<Entertainer> Entertainers { get; set; }

    }
}
