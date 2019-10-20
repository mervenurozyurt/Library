using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    interface IService<T> where T :IEntity
    {
        List<T> List();
        T Save(T obj);
        bool Update(T obj);

        T Get(int id);

    }
}
