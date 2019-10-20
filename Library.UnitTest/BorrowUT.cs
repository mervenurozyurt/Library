using System;
using System.Collections.Generic;
using Library.DTO;
using Library.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.UnitTest
{
    [TestClass]
    public class BorrowUT
    {
        private BorrowService service;

        [TestInitialize]
        public void SetUp()
        {
            service = new BorrowService();

        }

        [TestMethod]
        public void Borrow()
        {
            List<BorrowDTO> list = new List<BorrowDTO>();

            BorrowDTO book1 = new BorrowDTO
            {
                BookId=1,
                StudentId=1,
                BeginDate =new DateTime(2019,5,10),
                EndDate =new DateTime(2019, 5,13)
                

            };
            list.Add(book1);

            BorrowDTO book2 = new BorrowDTO
            {
                BookId =2,
                StudentId = 1,
                BeginDate = new DateTime(2019, 5, 10),
                EndDate =  new DateTime(2019, 5, 13),

            };
            list.Add(book2);

            var result = service.Borrow(list);
            Assert.IsTrue(result);


        }


        #region   List<BorrowDTO> list = new List<BorrowDTO>() { borrow1, borrow2, borrow3 };
        /*
                [TestMethod]
       public void Borrow()
       {
           BorrowDTO borrow1 = new BorrowDTO
           {
               BookId = 1,
               StudentId = 1,
               BeginDate = DateTime.Now,
               EndDate = DateTime.Now.AddDays(7)
           };

           BorrowDTO borrow2 = new BorrowDTO
           {
               BookId = 2,
               StudentId = 1,
               BeginDate = DateTime.Now,
               EndDate = DateTime.Now.AddDays(7)
           };

           BorrowDTO borrow3 = new BorrowDTO
           {
               BookId = 3,
               StudentId = 1,
               BeginDate = DateTime.Now,
               EndDate = DateTime.Now.AddDays(7)
           };

           List<BorrowDTO> list = new List<BorrowDTO>() { borrow1, borrow2, borrow3 };

           var result = service.Borrow(list);

           Assert.IsTrue(result);
       }
        */
        #endregion

        [TestMethod]
        public void Return()
        {
            int id = 1;
            var result = service.Return(id);
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void List()
        {

            var result = service.ListBorrows();
            Assert.IsNotNull(result);

        }


        [TestMethod]
        public void ListByis()
        {
            int id = 1;
            var result = service.ListBorrowedBooks(id);
            Assert.IsNotNull(result);

        }
    }
}
 
