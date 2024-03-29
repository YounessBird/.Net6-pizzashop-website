
using Microsoft.EntityFrameworkCore;

namespace PizzaShop.Infrastracture
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.UseSerialColumns();
        }
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

    }
}
