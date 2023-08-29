using Microsoft.EntityFrameworkCore;

namespace Product.DAL.Db_Context
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Domains.Product> Products { get; set; }
    }
}
