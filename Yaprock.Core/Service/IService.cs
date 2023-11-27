using System.Linq.Expressions;
using Yaprock.Core.Entities.BaseEntity;

namespace Yaprock.Core.Service
{
    public interface IService<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task Update(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRange(IEnumerable<T> entities);

    }
}
