using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ExamManagement.Application.Interfaces
{
    public interface ICrudManager<TEntity, TDto, TCreateDto, TUpdateDto>
    {
        TDto Add(TCreateDto createDto);
        TDto Delete(int Id);
        TDto Update(TUpdateDto updateDto);
        TDto GetById(int id);
        TDto Get(
            Expression<Func<TEntity, bool>> predicate,
            bool asNoTracking = false,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null
            );

        List<TDto> GetAll(
            Expression<Func<TEntity, bool>> predicate,
            bool asNoTracking = false,
            Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null
            );
    }
}
