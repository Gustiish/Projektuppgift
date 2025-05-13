using Microsoft.EntityFrameworkCore;
using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions):base(contextOptions)
        {
            
        }



    }
}
