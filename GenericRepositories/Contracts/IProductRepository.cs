using Product.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositories.Contracts
{
    public interface IProductRepository : IGenericRepository<Product.Domains.Product>
    {
        Task<object> GetCustomData(Expression<Func<Product.Domains.Product, bool>> predicate);
    }
}
