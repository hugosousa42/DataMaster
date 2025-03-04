using DataMaster.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataMaster.Data
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
