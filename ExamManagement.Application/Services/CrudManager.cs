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
        protected readonly IGenericInterface<TEntity> _databaseCrud;
        protected readonly IMapper _mapper;
        public CrudManager()
        {
            _databaseCrud = new GenericRepository<TEntity>();
        }


        public TDto Add(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);
            _databaseCrud.Add(entity);

            return _mapper.Map<TDto>(entity);
        }

        public TDto Delete(int Id)
        {
            var entity = _databaseCrud.GetById(Id);
            _databaseCrud.Delete(entity);

            return _mapper.Map<TDto>(entity);
        }

        public TDto Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            var entity = _databaseCrud.Get(predicate, asNoTracking, include);

            return _mapper.Map<TDto>(entity);
        }

        public List<TDto> GetAll(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            var entities = _databaseCrud.GetAll(predicate, asNoTracking, include);

            return _mapper.Map<List<TDto>>(entities);
        }

        public TDto GetById(int id)
        {
            var entity = _databaseCrud.GetById(id);

            return _mapper.Map<TDto>(entity);
        }

        public TDto Update(TUpdateDto updateDto)
        {
            var entity = _mapper.Map<TEntity>(updateDto);
            var updatedEntity = _databaseCrud.GetById(entity.Id);
            updatedEntity = entity;

            return _mapper.Map<TDto>(updatedEntity);
        }
    }
}
