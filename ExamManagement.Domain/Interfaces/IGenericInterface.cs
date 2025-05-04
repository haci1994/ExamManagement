using ExamManagement.Domain.Entities;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace ExamManagement.Domain.Interfaces
{
    public interface IGenericInterface<TEntity> where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);
        TEntity Delete(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity GetById(int id);
        TEntity Get(
            Expression<Func<TEntity, bool>> predicate,
            bool asNoTracking = false,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null
            );

        List<TEntity> GetAll(
            Expression<Func<TEntity, bool>> predicate,
            bool asNoTracking = false,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null
            );
    }
}
