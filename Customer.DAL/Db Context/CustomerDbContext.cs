using Microsoft.EntityFrameworkCore;

namespace Customer.DAL.Db_Context
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
        {

        }

        public DbSet<Domains.Customer> Customers { get; set; }
    }
}
