using MuseumSystem.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace MuseumSystem.Core
{
    public class MuseumSystemDbContext : DbContext
    {
        public MuseumSystemDbContext(DbContextOptions<MuseumSystemDbContext> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<DateEvent> DateEvents { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<ImageEvent> ImageEvents { get; set; }
        public DbSet<Museum> Museums { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<RecordClient> RecordClients { get; set; }
        public DbSet<SocialStatus> SocialStatuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .HasOne(a => a.Museum)
                .WithMany(m => m.Admins)
                .HasForeignKey(a => a.MuseumId);

            modelBuilder.Entity<DateEvent>()
                .HasOne(de => de.Event)
                .WithMany(e => e.DateEvents)
                .HasForeignKey(de => de.EventId);

            modelBuilder.Entity<Event>()
                .HasOne(e => e.Museum)
                .WithMany(m => m.Events)
                .HasForeignKey(e => e.MuseumId);

            modelBuilder.Entity<ImageEvent>()
                .HasOne(ie => ie.Event)
                .WithMany(e => e.ImageEvents)
                .HasForeignKey(ie => ie.EventId);

            modelBuilder.Entity<Record>()
                .HasOne(r => r.SocialStatus)
                .WithMany()
                .HasForeignKey(r => r.SocialStatusId);

            modelBuilder.Entity<Record>()
                .HasOne(r => r.Event)
                .WithMany(e => e.Record)
                .HasForeignKey(r => r.EventId);

            modelBuilder.Entity<RecordClient>()
                .HasOne(rc => rc.Record)
                .WithMany()
                .HasForeignKey(rc => rc.RecordId);

            modelBuilder.Entity<RecordClient>()
                .HasOne(rc => rc.Client)
                .WithMany()
                .HasForeignKey(rc => rc.ClientId);

            // Дополнительные конфигурации могут быть добавлены здесь
        }
    }
}
