using System;
using Library.DTO;
using Library.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library.UnitTest
{
    [TestClass]
    public class StudentServiceUT
    {
        StudentService service;

        [TestInitialize]
        public void SetUp()
        {
            service = new StudentService();
        }

        [TestMethod]
        public void Save()
        {
            StudentDTO student = new StudentDTO
            {
                FirstName ="Büşra Nur",
                LastName ="Baykal",
                StudentNumber ="1201020014",
                MobilePhone="05533065339",
                EmailAdress ="b.nurbaykal@hotmail.com",


            };

            var result = service.Save(student);
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void Update()
        {
            StudentDTO student = new StudentDTO
            {
                StudentId =2,
                FirstName = "Medeni",
                LastName = "Baykal",
                StudentNumber = "15314287",
                MobilePhone = "05526229767",
                EmailAdress = "medeni@baykal.com",
                CreatedDate =DateTime.Now,
                RecordStatusId =1

            };

            var result = service.Update(student);
            Assert.IsTrue(result);
        }


        [TestMethod]
        public void List()
        {
            Assert.IsNotNull(service.List());
        }


        [TestMethod]
        public void Get()
        {
            int id = 2;
            Assert.IsNotNull(service.Get(id));
        }
    }
}
