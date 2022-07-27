using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
    }
}
