using ExamManagement.Domain.Entities;
using ExamManagement.Domain.Interfaces;
using ExamManagement.Infrastructure.EfCore.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ExamManagement.Infrastructure.EfCore.Repositories
{
    public class GenericRepository<TEntity> : IGenericInterface<TEntity> where TEntity : BaseEntity
    {
        protected readonly AppDbContext _context;

        public GenericRepository()
        {
            _context = new AppDbContext();
        }

        public TEntity Add(TEntity entity)
        {
            var added = _context.Set<TEntity>().Add(entity);

            _context.SaveChanges();

            return added.Entity;
        }

        public TEntity Delete(TEntity entity)
        {
            var deleted = _context.Set<TEntity>().Remove(entity);

            return deleted.Entity;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = query.Where(predicate);

            if (!asNoTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include.Invoke(query);
            }

            return query.FirstOrDefault() ?? throw new InvalidOperationException("No such entity...");
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();

            query = query.Where(predicate);

            if (!asNoTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include.Invoke(query);
            }

            if(orderBy != null)
            {
                query = orderBy.Invoke(query);
            }

            return query.ToList();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id) ?? throw new InvalidOperationException("No such entity...");
        }

        public TEntity Update(TEntity entity)
        {
            var updated = _context.Set<TEntity>().Update(entity);

            return updated.Entity;
        }
    }
}
