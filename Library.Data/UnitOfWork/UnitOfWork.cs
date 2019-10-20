using Library.Data.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private LibraryDBEntities db;
        private DbContextTransaction transaction;
        

        public UnitOfWork()
        {
            db = new LibraryDBEntities();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public bool Commit()
        {
            transaction = db.Database.BeginTransaction(); //trabssac a başla
            int affected = db.SaveChanges(); //değişiklikleri kaydetsn
            transaction.Commit(); //uygulasın
            return affected > 0;

        }

        public void RollBack()
        {
            transaction.Rollback();
        }


        public Repository<Book> Books { get { return new Repository<Book>(db); } }
        public Repository<Borrow> Borrows { get { return new Repository<Borrow>(db); } }
        public Repository<Genre> Genres { get { return new Repository<Genre>(db); } }
        public Repository<RecordStatus> RecordStatuses { get { return new Repository<RecordStatus>(db); } }
        public Repository<Student> Students { get { return new Repository<Student>(db); } }
        public Repository<User> Users { get { return new Repository<User>(db); } }

        public Repository<Penalty> Penalties { get { return new Repository<Penalty>(db); } }


    }
}
