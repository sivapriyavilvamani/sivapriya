using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DhanmayaAirlines.Models
{
    public partial class DhanmayaAirlinesContext : DbContext
    {
        public DhanmayaAirlinesContext()
        {
        }

        public DhanmayaAirlinesContext(DbContextOptions<DhanmayaAirlinesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BookingDetail> BookingDetails { get; set; } = null!;
        public virtual DbSet<FlightAvailableSeat> FlightAvailableSeats { get; set; } = null!;
        public virtual DbSet<FlightDetail> FlightDetails { get; set; } = null!;
        public virtual DbSet<FlightSchedule> FlightSchedules { get; set; } = null!;
        public virtual DbSet<FlightSeatCost> FlightSeatCosts { get; set; } = null!;
        public virtual DbSet<Registration> Registrations { get; set; } = null!;
        public virtual DbSet<Schedule> Schedules { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=DhanmayaAirlines;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookingDetail>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__BookingD__73951AED1FE9AA29");

                entity.Property(e => e.Fasid).HasColumnName("FASId");

                entity.Property(e => e.Fscid).HasColumnName("FSCId");

                entity.Property(e => e.Fsid).HasColumnName("FSId");

                entity.Property(e => e.RegId).HasColumnName("RegID");
            });

            modelBuilder.Entity<FlightAvailableSeat>(entity =>
            {
                entity.HasKey(e => e.Fasid)
                    .HasName("PK__FlightAv__4B09F410680080F4");

                entity.Property(e => e.Fasid).HasColumnName("FASId");

                entity.Property(e => e.SeatNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlightDetail>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK__FlightDe__8A9E14EE9BDBBD2B");

                entity.Property(e => e.AirlinesName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Enginetype)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FlightName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlightSchedule>(entity =>
            {
                entity.HasKey(e => e.Fsid)
                    .HasName("PK_FSId");

                entity.ToTable("FlightSchedule");

                entity.Property(e => e.Fsid).HasColumnName("FSId");
            });

            modelBuilder.Entity<FlightSeatCost>(entity =>
            {
                entity.HasKey(e => e.Fscid)
                    .HasName("PK__FlightSe__9764A11CEA1CFB67");

                entity.ToTable("FlightSeatCost");

                entity.Property(e => e.Fscid).HasColumnName("FSCId");

                entity.Property(e => e.Cost)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("cost");

                entity.Property(e => e.Fasid).HasColumnName("FASId");

                entity.Property(e => e.SeatType)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__Registra__2C6822F84962A734");

                entity.ToTable("Registration");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.ToTable("Schedule");

                entity.Property(e => e.Arrival).HasColumnType("datetime");

                entity.Property(e => e.Departure).HasColumnType("datetime");

                entity.Property(e => e.DestinamtionTerminal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Destinamtion_Terminal");

                entity.Property(e => e.Destination)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTerminal)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Source_Terminal");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
