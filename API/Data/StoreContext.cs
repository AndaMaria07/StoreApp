using Microsoft.EntityFrameworkCore;
using API.Entities;
namespace API.Data
{
    public partial class StoreContext : DbContext
    {
        IConfiguration _configuration;

        public StoreContext(DbContextOptions options) : base(options)
        {
        
        }

        public DbSet<Product> Products { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        //     if(!optionsBuilder.IsConfigured){
        //         optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
        //     }
        // }
    }
}