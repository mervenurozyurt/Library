using Library.Data;
using Library.Data.UnitOfWork;
using Library.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class BorrowService : BaseService
    {

        public bool Borrow(List<BorrowDTO> obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    //bir öğrenci birden fazla kitap alabilir o yüzdn liste
                    foreach (var item in obj)
                    {
                        item.BeginDate = DateTime.Now;
                        item.EndDate = DateTime.Now.AddDays(14);
                        var entity = Mapper.Map<BorrowDTO, Borrow>(item);

                        uow.Borrows.Save(entity);

                        //ödünç verdiğim kitap için adedini bir azalttım
                        //önce kitabı bul2
                        var book = uow.Books.Get(item.BookId);
                        book.UnitsInStock -= 1;

                        uow.Books.Update(book);
                    }

                    return uow.Commit();
                }
                catch (Exception ex)
                {

                    uow.RollBack();
                    return false;
                }
             
            }

        }

        public bool Return(int studentid, decimal penalty)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {

                    var entity = uow.Borrows.Search(x => x.StudentId == studentid && x.ReturnDate ==null);

                    if (entity.Count ==0)
                    {
                        return false;
                    }

                    foreach (var item in entity)
                    {
                        item.ReturnDate = DateTime.Now;
                        uow.Borrows.Update(item);

                        var bookEntity = uow.Books.Get(item.BookId);
                        bookEntity.UnitsInStock += 1;
                        uow.Books.Update(bookEntity);

                    }

                    if (penalty >0)
                    {
                        Penalty penaltyentitiy = new Penalty
                        {
                            BorrowId = entity[0].BorrowId,
                            Penalty1 = penalty

                        };

                        uow.Penalties.Save(penaltyentitiy); 
                    }

                    return uow.Commit();
                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return false;
                }

            }

        }



        public List<BorrowDTO> ListBorrows()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entities = uow.Borrows.Search(x=>x.ReturnDate ==null && x.EndDate<DateTime.Now);
                if (entities.Count > 0)
                {
                    List<BorrowDTO> list = new List<BorrowDTO>();

                    foreach (var item in entities)
                    {
                        BorrowDTO borrow = new BorrowDTO
                        {
                            StudentId = item.StudentId,
                            StudentName = item.Student.FirstName + " " + item.Student.LastName,
                           // NumberofBooks = entities.Where(x=>x.StudentId==item.StudentId && x.ReturnDate ==null).Count(),
                        };

                        list.Add(borrow);


                    }
                  list=  list.GroupBy(x => new { StudentId = x.StudentId, StudentName = x.StudentName })
                        .Select(x => new BorrowDTO
                        {
                            StudentId =x.Key.StudentId,
                            StudentName =x.Key.StudentName,
                            NumberofBooks=x.Count()
                            
                        }).ToList();


                    return list;
                }
                else
                {
                    return null;
                }

            }
          
        }


        public List<BookDTO> ListBorrowedBooks(int studentid)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                
                var borrow = uow.Borrows.Search(x=>x.StudentId ==studentid &&x.ReturnDate ==null);
                List<BookDTO> list = new List<BookDTO>();

                foreach (var item in borrow)
                {
                    var bookEntity = uow.Books.Get(item.BookId);
                    BookDTO bookDTO = new BookDTO
                    {
                        BookId =bookEntity.BookId,
                        BookName =bookEntity.BookName

                    };

                    list.Add(bookDTO);

                   
                }

                return list;

            }
            
        }

       public InformationDTO GetBorrowDetails(int studentId)
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                var borrows = uow.Borrows.Search(x =>x.StudentId ==studentId && x.ReturnDate == null && x.EndDate < DateTime.Now);

                InformationDTO info = new InformationDTO
                {
                    EndDate =borrows[0].EndDate,
                    LateDays =(DateTime.Now -borrows[0].EndDate).Days,
                    NumberOfBooks =borrows.Count

                };

                return info;

            }

        }



        public int GetNumberOfBorrows (int bookId)
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                return uow.Borrows.Search(x=>x.BookId ==bookId).Count;

            }

        }


        public List<StudentDTO>  GetPEnaltyStudents()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {

                var result = uow.Penalties.List();
                List<StudentDTO> list = new List<StudentDTO>();

                if (list.Count ==0)
                {
                    return null;
                }

                foreach (var item in result)
                {
                    StudentDTO studentDTO = new StudentDTO
                    {
                        StudentId = item.Borrow.StudentId,
                        FirstName =item.Borrow.Student.FirstName,
                        LastName =item.Borrow.Student.LastName


                    };

                    list.Add(studentDTO);
                }

                return list;

            }

        }


    }
}
