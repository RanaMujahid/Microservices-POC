using GenericRepositories.Contracts;
using Product.DAL.Db_Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositories.Repositories
{
    public class ProductRepository : GenericRepository<Product.Domains.Product>, IProductRepository
    {
        public ProductRepository(ProductDbContext productDbContext):base(productDbContext)
        {

        }

        public async Task<object> GetCustomData(Expression<Func<Product.Domains.Product, bool>> predicate)
        {
            var data = base.Query().Where(predicate).Select(x => new { x.Name, x.Price });
            var test = data.FirstOrDefault();

            return await Task.FromResult(data);
        }
    }
}
