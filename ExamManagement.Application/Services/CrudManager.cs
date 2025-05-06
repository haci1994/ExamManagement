using AutoMapper;
using ExamManagement.Application.AutoMapping;
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
        protected readonly IGenericInterface<TEntity> DatabaseCrud;
        protected readonly IMapper _mapper;
        public CrudManager()
        {
            DatabaseCrud = new GenericRepository<TEntity>();

            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();

            });

            _mapper = config.CreateMapper();
        }


        public TDto Add(TCreateDto createDto)
        {
            var entity = _mapper.Map<TEntity>(createDto);
            DatabaseCrud.Add(entity);

            return _mapper.Map<TDto>(entity);
        }

        public TDto Delete(int Id)
        {
            var entity = DatabaseCrud.GetById(Id);
            DatabaseCrud.Delete(entity);

            return _mapper.Map<TDto>(entity);
        }

        public TDto Get(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            var entity = DatabaseCrud.Get(predicate, asNoTracking, include);

            return _mapper.Map<TDto>(entity);
        }

        public List<TDto> GetAll(Expression<Func<TEntity, bool>> predicate, bool asNoTracking = false, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null)
        {
            var entities = DatabaseCrud.GetAll(predicate, asNoTracking, include);

            return _mapper.Map<List<TDto>>(entities);
        }

        public TDto GetById(int id)
        {
            var entity = DatabaseCrud.GetById(id);

            return _mapper.Map<TDto>(entity);
        }

        public TDto Update(TUpdateDto updateDto)
        {
            var entity = _mapper.Map<TEntity>(updateDto);
            var updatedEntity = DatabaseCrud.GetById(entity.Id);
            updatedEntity = entity;

            return _mapper.Map<TDto>(updatedEntity);
        }
    }
}
