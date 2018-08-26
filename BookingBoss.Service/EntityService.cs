using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BookingBoss.Domain;
using BookingBoss.Infrastructure;

namespace BookingBoss.Service
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        protected IContext _context;
        protected IDbSet<T> _dbset;

        public EntityService(IContext context)
        {
            _context = context;
            _dbset = _context.Set<T>();
        }

        public virtual T GetById(long id)
        {
            return _dbset.Find(id);
        }

        public virtual void Create(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dbset.Add(entity);
            _context.SaveChanges();
        }

        public async Task CreateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            _dbset.Add(entity);
            await _context.SaveChangesAsync();
        }

        public virtual void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public virtual void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _dbset.Remove(entity);
            _context.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _dbset.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public T FirtOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbset.FirstOrDefault(predicate);
        }

        public async Task<T> FirtOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.FirstOrDefaultAsync(predicate);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _dbset.Where(predicate).AsEnumerable();
        }

        public async Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.Where(predicate).ToListAsync();
        }
    }
}
