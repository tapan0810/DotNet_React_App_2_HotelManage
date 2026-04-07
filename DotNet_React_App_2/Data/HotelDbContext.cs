using DotNet_React_App_2.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNet_React_App_2.Data
{
    public class HotelDbContext: DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }
        public DbSet<Hotel> Hotels => Set<Hotel>();
    }
}
