using HotelListing.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.Data
{
    public class DataBaseContext : IdentityDbContext<ApiUser>
    {

        public DataBaseContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Country> countries { get; set; }
        public DbSet<Hotel> hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CountryConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
