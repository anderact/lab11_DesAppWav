using Microsoft.EntityFrameworkCore;
using lab11.Models;

namespace lab11.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) 
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<lab11.Models.Customer>? Customer { get; set; }
    }
}
