using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniBlog.Domain.Service.Base
{

    public interface IBaseService<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task Add(T obj);
    }
}
