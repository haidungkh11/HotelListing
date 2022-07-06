using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Hanoi",
                    ShortName = "HN"
                },
                new Country
                {
                    Id = 2,
                    Name = "HoChiMinh",
                    ShortName = "HCM"
                },
                new Country
                {
                    Id = 3,
                    Name = "HaLong",
                    ShortName = "HL"
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Prime Center Hotel",
                    Address = "Hoan Kiem",
                    Rating = 4.5,
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Sunshine Hotel",
                    Address = "Quan 3",
                    Rating = 4.8,
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Ascotic Hotel",
                    Address = "Bai Chay",
                    Rating = 4.6,
                    CountryId = 3
                }
                );

        }
        
        public DbSet<Country> countries { get; set; }
        public DbSet<Hotel> hotels { get; set; }

    }
}
