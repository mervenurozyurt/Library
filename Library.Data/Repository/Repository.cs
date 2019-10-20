using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private LibraryDBEntities _db;
        public Repository(LibraryDBEntities db)
        {
            _db = db; //repos a ne verirsem onu kullancan siyorum
        }

        public void Delete(Expression<Func<T, bool>> predicate)
        {
            var entity = _db.Set<T>().FirstOrDefault(predicate);
            _db.Set<T>().Remove(entity);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public T Get(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public List<T> List()
        {
            return _db.Set<T>().ToList();
        }

        public T Save(T obj)
        {
            var entity = _db.Set<T>().Add(obj);
            return entity;
        }

        public List<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }

        public void Update(T obj)
        {
            _db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
