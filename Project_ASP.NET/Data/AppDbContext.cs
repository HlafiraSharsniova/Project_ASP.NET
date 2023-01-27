using Microsoft.EntityFrameworkCore;
using Project_ASP.NET.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Project_ASP.NET.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Procedure_Reservation>().HasKey(pr => new
            {
                pr.ProcedureID,
                pr.ReservationID
            });

            
            modelBuilder.Entity<Procedure_Reservation>().HasOne(r => r.Reservation).WithMany(pr => pr.Procedures_Reservations).HasForeignKey(r => r.ReservationID);
            modelBuilder.Entity<Procedure_Reservation>().HasOne(r => r.Procedure).WithMany(pr => pr.Procedures_Reservations).HasForeignKey(r => r.ProcedureID);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Procedure_Reservation> Procedures_Reservations { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Client> Clients { get; set; }


    }
}