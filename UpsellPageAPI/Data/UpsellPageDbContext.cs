using Microsoft.EntityFrameworkCore;
using UpsellPageAPI.Entities;

namespace UpsellPageAPI.Data
{
    public class UpsellPageDbContext : DbContext
    {
        public UpsellPageDbContext(DbContextOptions<UpsellPageDbContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}
