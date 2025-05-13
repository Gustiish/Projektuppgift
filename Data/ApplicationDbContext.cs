using Microsoft.EntityFrameworkCore;
using Projektuppgift.Models;

namespace Projektuppgift.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CarRental> Cars { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions):base(contextOptions)
        {
            
        }



    }
}
