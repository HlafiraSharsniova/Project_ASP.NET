﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_ASP.NET.Data;

#nullable disable

namespace ProjectASP.NET.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_ASP.NET.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PhoneNumber")
                        .HasMaxLength(9)
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Master", b =>
                {
                    b.Property<int>("MasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MasterId"));

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MasterId");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Procedure", b =>
                {
                    b.Property<int>("ProcedureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProcedureId"));

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("ProcedureId");

                    b.ToTable("Procedures");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Procedure_Reservation", b =>
                {
                    b.Property<int>("ProcedureID")
                        .HasColumnType("int");

                    b.Property<int>("ReservationID")
                        .HasColumnType("int");

                    b.HasKey("ProcedureID", "ReservationID");

                    b.HasIndex("ReservationID");

                    b.ToTable("Procedures_Reservations");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfReservation")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionOfReservation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MasterID")
                        .HasColumnType("int");

                    b.Property<string>("NameOfReservation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcedureCategory")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeOfReservation")
                        .HasColumnType("datetime2");

                    b.Property<string>("imgOfReservation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("priceOfReservation")
                        .HasColumnType("float");

                    b.HasKey("ReservationId");

                    b.HasIndex("ClientID");

                    b.HasIndex("MasterID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Procedure_Reservation", b =>
                {
                    b.HasOne("Project_ASP.NET.Models.Procedure", "Procedure")
                        .WithMany("Procedures_Reservations")
                        .HasForeignKey("ProcedureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_ASP.NET.Models.Reservation", "Reservation")
                        .WithMany("Procedures_Reservations")
                        .HasForeignKey("ReservationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Procedure");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Reservation", b =>
                {
                    b.HasOne("Project_ASP.NET.Models.Client", "Client")
                        .WithMany("Reservations")
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project_ASP.NET.Models.Master", "Master")
                        .WithMany("Reservations")
                        .HasForeignKey("MasterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Master");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Client", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Master", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Procedure", b =>
                {
                    b.Navigation("Procedures_Reservations");
                });

            modelBuilder.Entity("Project_ASP.NET.Models.Reservation", b =>
                {
                    b.Navigation("Procedures_Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
