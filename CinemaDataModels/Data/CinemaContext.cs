using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CinemaDataModels.Models.Entities;

namespace CinemaDataModels.Data
{
    public class CinemaContext : DbContext
    {
        private readonly DbContextOptions dbContextOptions;
        public CinemaContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            this.dbContextOptions = dbContextOptions;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<PostalCode> PostalCodes { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Theater> Theaters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

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
                .HasPrecision(2, 1);
            });
            modelBuilder.Entity<PostalCode>(entity =>
            {
                entity.HasKey(e => e.PostalCodeId);
                entity.Property(e => e.PostalCodeId)
                .ValueGeneratedNever();
            });
            modelBuilder.Entity<Movie>(entity => 
            {
                entity.Property(e => e.Rating).HasPrecision(3, 1);
            });
        }
    }
}
