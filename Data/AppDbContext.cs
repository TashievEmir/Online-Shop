using Asp.NetMvcApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Asp.NetMvcApp.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        /*    Database.EnsureDeleted();
            Database.EnsureCreated();*/
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=LocalDatabase.db");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
