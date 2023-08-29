using Customer.DAL.Db_Context;
using Customer.DAL.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Customer.DAL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private CustomerDbContext _dbContext;
        public CustomerRepository(CustomerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Domains.Customer customer)
        {
            try
            {
                await _dbContext.AddAsync(customer);

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Domains.Customer>> GetAll()
        {
            try
            {
                return await _dbContext.Customers.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task Commit()
        {
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
