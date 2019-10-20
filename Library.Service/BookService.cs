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
    public class BookService : BaseService, IService<BookDTO>
    {
        public BookDTO Get(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = uow.Books.Get(id);

                    BookDTO bookDTO = Mapper.Map<Book, BookDTO>(entity);
                    bookDTO.GenreName = entity.Genre.GenreName;
                    bookDTO.RecordStatusName = entity.RecordStatus.RecordStatusName;

                    return bookDTO;
                }
                catch (Exception ex)
                {

                    return null;
                }

            }

          

        }

        public List<BookDTO> List()
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entites = uow.Books.List();

                    List<BookDTO> list = new List<BookDTO>();
                    foreach (var item in entites)
                    {
                        BookDTO book = new BookDTO()
                        {
                            BookId = item.BookId,
                            BookName = item.BookName,
                            UnitsInStock = item.UnitsInStock

                        };

                        list.Add(book);
                    }

                    return list;
                }
                catch (Exception ex)
                {

                    return null;
                }
            }

           
        }

        public BookDTO Save(BookDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    obj.CreatedDate = DateTime.Now;
                    obj.RecordStatusId = Convert.ToByte(Enums.RecordStatus.Aktif);
                    var entites = Mapper.Map<BookDTO, Book>(obj);
                    uow.Books.Save(entites);
                    uow.Commit();

                    return Mapper.Map<Book, BookDTO>(entites);



                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return null;
                }
            }
        }

        public bool Update(BookDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                   
                    var entites = Mapper.Map<BookDTO, Book>(obj);
                    uow.Books.Update(entites);
                   return  uow.Commit();
                    
                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return false;
                }
            }
        }


        public List<BookDTO> ListByGenre(byte gnreid)
        {

            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entites = uow.Books.Search(x=>x.GenreId ==gnreid );

                    List<BookDTO> list = new List<BookDTO>();
                    foreach (var item in entites)
                    {
                        BookDTO book = new BookDTO()
                        {
                            BookId = item.BookId,
                            BookName = item.BookName,
                            UnitsInStock = item.UnitsInStock

                        };

                        list.Add(book);
                    }

                    return list;
                }
                catch (Exception ex)
                {

                    return null;
                }
            }


        }
    }
}
