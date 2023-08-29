using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepositories.Contracts
{
    public interface IGenericRepository<T> : IDisposable where T : class
    {
        IQueryable<T> Query();
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> FindWhereAsync(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> GetAllWithIncludesAsync(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetSingleWhereAsync(Expression<Func<T, bool>> predicate);
        Task<TResult> SelectColumnsWhereAsync<TResult>(
                                            Expression<Func<T, bool>> predicate,
                                            Expression<Func<T, TResult>> selector);
        Task<T> GetSingleWithIncludesAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<int> CountAsync();
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteWhere(Expression<Func<T, bool>> predicate);
        Task CommitAsync();
    }
}
