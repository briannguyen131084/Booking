using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BookingBoss.Domain;

namespace BookingBoss.Service
{
    public interface IService
    {
        
    }

    public interface IEntityService<T> : IService where T : BaseEntity
    {
        T GetById(long id);
        void Create(T entity);
        Task CreateAsync(T entity);
        void Update(T entity);
        Task UpdateAsync(T entity);
        void Delete(T entity);
        Task DeleteAsync(T entity);
        T FirtOrDefault(Expression<Func<T, bool>> predicate);
        Task<T> FirtOrDefaultAsync(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate);
    }
}
