using AutoMapper;
using ExamManagement.Application.Interfaces;
using ExamManagement.Domain.Entities;
using ExamManagement.Domain.Interfaces;
using ExamManagement.Infrastructure.EfCore.Repositories;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace ExamManagement.Application.Services
{
    public class CrudManager<TEntity, TDto, TCreateDto, TUpdateDto> : ICrudManager<TEntity, TDto, TCreateDto, TUpdateDto> where TEntity : BaseEntity
    {
        private readonly IGenericInterface<TEntity> _databaseCrud;
        private readonly IMapper _mapper;
        public CrudManager()
            {
                _databaseCrud = new GenericRepository<TEntity>();
            }


        public TDto Add(TCreateDto createDto)
        {
            
        }

        public TDto Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public TDto Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            throw new NotImplementedException();
        }

        public List<TDto> GetAll(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            throw new NotImplementedException();
        }

        public TDto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TDto Update(TUpdateDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
