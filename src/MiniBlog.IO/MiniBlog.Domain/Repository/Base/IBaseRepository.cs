using MiniBlog.Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBlog.Domain.Repository.Base
{
    public interface IBaseRepository<T>
    {
        Task Add(T obj);
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> GetAll();
        Task Update(T obj);
        Task Remove(Guid id);
    }
}
