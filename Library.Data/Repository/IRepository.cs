using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
   public interface IRepository<T> : IDisposable where T:class
    {
        List<T> List();
        T Save(T obj);
       void Update(T obj);
        void Delete(Expression<Func<T, bool>> predicate);
        T Get(int id);

        List<T> Search(Expression<Func<T, bool>>predicate);

    }
}
