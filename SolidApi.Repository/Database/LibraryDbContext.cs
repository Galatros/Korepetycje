using Microsoft.EntityFrameworkCore;
using SolidApi.Repository.Database.Entities;

namespace SolidApi.Repository.Database
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //tworzmy primary Key z pary kluczy UserId i CompanyId
            modelBuilder.Entity<UserToCompany>()
                .HasKey(utc => new { utc.UserId, utc.CompanyId });

            //Wskazyjemy, ze jeden uzytkownik moge wskazywac na wiele polaczen, a kluczem jest UserId
            modelBuilder.Entity<UserToCompany>()
                .HasOne(utc => utc.User)
                .WithMany(utc => utc.UserToCompanies)
                .HasForeignKey(utc => utc.UserId);

            //Wskazyjemy, ze jedna firma moge wskazywac na wiele polaczen, a kluczem jest CompanyId
            modelBuilder.Entity<UserToCompany>()
                .HasOne(utc => utc.Company)
                .WithMany(utc => utc.UserToCompanies)
                .HasForeignKey(utc => utc.CompanyId);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Company> Companies { get; set; }

        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<UserToCompany> UserToCompanies { get; set; }
    }
}
