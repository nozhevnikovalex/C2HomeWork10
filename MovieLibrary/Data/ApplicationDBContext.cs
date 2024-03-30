using WebApplication10.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication10.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Showtime> Showtimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Showtime>()
                .HasOne(s => s.Movie)
                .WithMany(m => m.Showtimes)
                .HasForeignKey(s => s.MovieId);

            modelBuilder.Entity<Movie>().HasData(
                new Movie { Id = 1, Title = "Фільм 1", Director = "Режисер 1", Genre = "Жанр 1", Description = "Опис фільму 1" },
                new Movie { Id = 2, Title = "Фільм 2", Director = "Режисер 2", Genre = "Жанр 2", Description = "Опис фільму 2" },
                new Movie { Id = 3, Title = "Фільм 3", Director = "Режисер 3", Genre = "Жанр 3", Description = "Опис фільму 3" }
            );

            modelBuilder.Entity<Showtime>().HasData(
                new { Id = 1, StartTime = new DateTime(2024, 4, 1, 10, 0, 0), MovieId = 1 },
                new { Id = 2, StartTime = new DateTime(2024, 4, 1, 14, 0, 0), MovieId = 1 },
                new { Id = 3, StartTime = new DateTime(2024, 4, 1, 18, 0, 0), MovieId = 2 },
                new { Id = 4, StartTime = new DateTime(2024, 4, 1, 20, 0, 0), MovieId = 2 },
                new { Id = 5, StartTime = new DateTime(2024, 4, 2, 10, 0, 0), MovieId = 3 }
            );

            
        }
    }
}
