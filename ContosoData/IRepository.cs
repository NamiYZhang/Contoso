using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoData
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Create(T obj);

    }
}
