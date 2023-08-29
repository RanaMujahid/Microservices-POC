using Microsoft.EntityFrameworkCore;
using Product.DAL.Db_Context;
using Product.DAL.IRepositories;

namespace Product.DAL.Repositories
{
    //public class ProductRepository : IProductRepository
    //{
    //    private readonly ProductDbContext _dbContext;
    //    public ProductRepository(ProductDbContext dbContext)
    //    {
    //        _dbContext = dbContext;
    //    }

    //    public async Task Add(Domains.Product product)
    //    {
    //        try
    //        {
    //           await _dbContext.AddAsync(product);
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //    }

    //    public void Update(Domains.Product product)
    //    {
    //        try
    //        {
    //            _dbContext.Update(product);
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //    }
    //    public async Task<IEnumerable<Domains.Product>> GetAll()
    //    {
    //        try
    //        {
    //            return await _dbContext.Products.ToListAsync();
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //    }

    //    public async Task<Domains.Product> GetById(int id)
    //    {
    //        try
    //        {
    //            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
    //        }
    //        catch (Exception)
    //        {
    //            throw;
    //        }
    //    }
    //    public async Task Commit()
    //    {
    //        try
    //        {
    //            await _dbContext.SaveChangesAsync();
    //        }
    //        catch (Exception)
    //        {

    //            throw;
    //        }
    //    }
    //}
}
