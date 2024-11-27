using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CinemaDataModels.Models.Entities;

namespace CinemaDataModels.Data
{
    public class CinemaContext : DbContext
    {
        private readonly DbContextOptions<CinemaContext> options;

        public CinemaContext(DbContextOptions<CinemaContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserName)
                      .HasMaxLength(50).IsRequired();
                entity.Property(e => e.Password)
                      .HasMaxLength(50).IsRequired();
                entity.Property(e => e.Email)
                      .HasMaxLength(50).IsRequired();
                entity.Property(e => e.CreatedAt)
                      .HasDefaultValueSql("GETDATE()");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Rating)
                      .HasPrecision(3, 1);
            });

            modelBuilder.Entity<PostalCode>(entity =>
            {
                entity.HasKey(e => e.PostalCodeId);
                entity.Property(e => e.PostalCodeId)
                      .ValueGeneratedNever();
            });
            modelBuilder.Entity<Theater>()
                .HasOne(t => t.Address)
                .WithOne()
                .HasForeignKey<Theater>(t => t.AddressId);
            base.OnModelCreating(modelBuilder);
        }
    }
}

