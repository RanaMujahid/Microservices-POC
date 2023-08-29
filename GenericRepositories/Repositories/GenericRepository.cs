using GenericRepositories.Contracts;
using Microsoft.EntityFrameworkCore;
using Product.DAL.Db_Context;
using System.Linq.Expressions;

namespace GenericRepositories.Repositories
{
    /// <summary>
    /// Generic base repository for communicating with the database.
    /// Author: Mujahid H.
    /// </summary>
    /// <typeparam name="T">Entity type.</typeparam>
    #nullable disable
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ProductDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public GenericRepository(ProductDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Returns an IQueryable for constructing custom queries.
        /// </summary>
        public virtual IQueryable<T> Query() => _context.Set<T>().AsQueryable();

        /// <summary>
        /// Retrieves all entities of type T.
        /// </summary>
        public virtual async Task<IEnumerable<T>> GetAllAsync()
            => await _context.Set<T>().AsNoTracking().ToListAsync();

        /// <summary>
        /// Retrieves entities using a stored procedure.
        /// </summary>
        public virtual async Task<IEnumerable<T>> GetListWithSPAsync(string storeProcedure, params string[] spParameters)
            => await _context.Set<T>().FromSqlRaw(storeProcedure, spParameters).ToListAsync();

        /// <summary>
        /// Executes a non-query stored procedure. (Insert, Update, Delete)
        /// </summary>
        public virtual async Task<int> ExecuteNonQuerySPAsync(string storeProcedure, T entity)
            => await _context.Database.ExecuteSqlRawAsync(storeProcedure, entity);

        /// <summary>
        /// Counts the total number of entities.
        /// </summary>
        public virtual async Task<int> CountAsync()
            => await _context.Set<T>().CountAsync();

        /// <summary>
        /// Retrieves all entities of type T with related entities included.
        /// </summary>
        public virtual async Task<IEnumerable<T>> GetAllWithIncludesAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.ToListAsync();
        }

        /// <summary>
        /// Retrieves entities of type T that satisfy a condition.
        /// </summary>
        public virtual async Task<IEnumerable<T>> FindWhereAsync(Expression<Func<T, bool>> predicate)
            => await _context.Set<T>().Where(predicate).AsNoTracking().ToListAsync();

        /// <summary>
        /// Retrieves a single entity of type T that satisfies a condition.
        /// </summary>
        public virtual async Task<T> GetSingleWhereAsync(Expression<Func<T, bool>> predicate)
            => await _context.Set<T>().FirstOrDefaultAsync(predicate);


        /// <summary>
        /// Retrieves selective entity columns of type T that satisfies a condition.
        /// </summary>
        public virtual async Task<TResult> SelectColumnsWhereAsync<TResult>(
                                            Expression<Func<T, bool>> predicate,
                                            Expression<Func<T, TResult>> selector) => await _context.Set<T>()
                .Where(predicate)
                .Select(selector)
                .FirstOrDefaultAsync();

        /// <summary>
        /// Retrieves a single entity of type T that satisfies a condition with related entities included.
        /// </summary>
        public virtual async Task<T> GetSingleWithIncludesAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = _context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return await query.FirstOrDefaultAsync(predicate);
        }

        /// <summary>
        /// Adds a new entity of type T.
        /// </summary>
        public virtual async Task AddAsync(T entity)
            => await _context.Set<T>().AddAsync(entity);

        /// <summary>
        /// Marks an entity of type T as updated.
        /// </summary>
        public virtual void Update(T entity)
            => _context.Set<T>().Update(entity);

        /// <summary>
        /// Marks an entity of type T for deletion.
        /// </summary>
        public virtual void Delete(T entity)
            => _context.Set<T>().Remove(entity);

        /// <summary>
        /// Deletes entities of type T that satisfy a condition.
        /// </summary>
        public virtual void DeleteWhere(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> entities = _context.Set<T>().Where(predicate);

            foreach (var entity in entities)
            {
                _context.Entry<T>(entity).State = EntityState.Deleted;
            }
        }

        /// <summary>
        /// Saves changes to the database.
        /// </summary>
        public virtual async Task CommitAsync()
            => await _context.SaveChangesAsync();

        /// <summary>
        /// Disposes of the context.
        /// </summary>
        public void Dispose()
        => _context.Dispose();
    }
}
