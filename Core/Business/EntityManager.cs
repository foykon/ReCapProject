using Core.DataAccess;
using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Business
{
    public class EntityManager<T> : IEntityService<T> where T : class, IEntity, new()
    {
        IEntityRepository<T> _entityRepository;
        public EntityManager(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public IResult Add(T entity)
        {
            _entityRepository.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
