using System.Collections.Generic;

namespace Common.Infrastructure.Repository
{
    public interface IBaseRepository<T> where T:class
    {
        
        IEnumerable<T> GetAll();

        T GetById(long id);

        void Add(T entity);

        void Remove(long Id);

        void Update(T entity);

    }
}
