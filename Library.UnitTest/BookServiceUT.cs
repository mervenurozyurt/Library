using System;
using Library.DTO;
using Library.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.UnitTest
{
    [TestClass]
    public class BookServiceUT
    {
        private BookService bookService;
        [TestInitialize]
        public void SetUp()
        {
            bookService = new BookService();
        }

        [TestMethod]
        public void SaveBook()
        {
            BookDTO book = new BookDTO
            {
                BookName = "Suç ve Ceza",
                GenreId = 4,
                Author = "Dostoyevski",
                PublishDate = new DateTime(2019, 1,1),

                UnitsInStock =20


            };
            BookDTO book1 = new BookDTO
            {
                BookName = "Kara Kule",
                GenreId = 1,
                Author = "Stephen King",
                PublishDate = new DateTime(2019, 1, 1),

                UnitsInStock = 20


            };
            BookDTO book2 = new BookDTO
            {
                BookName = "Harry Potter",
                GenreId = 1,
                Author = "JK Rowling",
                PublishDate = new DateTime(2019, 1, 1),

                UnitsInStock = 20


            };

            var result = bookService.Save(book1);
            var result1 = bookService.Save(book2);
          
            Assert.IsNotNull(result);
            Assert.IsNotNull(result1);
        }
        [TestMethod]
        public void List()
        {
            Assert.IsNotNull(bookService.List());
        }

        [TestMethod]
        public void Get()
        {
            int id = 3;
            Assert.IsNotNull(bookService.Get(id));
        }

        [TestMethod]
        public void Update()
        {
            BookDTO book = new BookDTO
            {
                BookId =3,
                BookName = "Harry Potter",
                GenreId =5,
                Author = "JK Rowling",
                PublishDate = new DateTime(2019, 1, 1),

                UnitsInStock = 15,
                CreatedDate = DateTime.Now,
                RecordStatusId = Convert.ToByte(Enums.RecordStatus.Aktif)


            };

            var result = bookService.Update(book);
            Assert.IsTrue(result);
        }
    }
}
