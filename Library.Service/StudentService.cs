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
  public  class StudentService : BaseService, IService<StudentDTO>
    {
        public StudentDTO Get(int id)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {

                    var entity = uow.Students.Get(id);
                    StudentDTO studentDTO = Mapper.Map<Student, StudentDTO>(entity);
                    studentDTO.RecordStatusName = entity.RecordStatus.RecordStatusName;
                    return studentDTO;
                }
                catch (Exception)
                {

                    return null;
                }


            }
        }

        public List<StudentDTO> List()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entites = uow.Students.List();
                    List<StudentDTO> list = new List<StudentDTO>();
                    foreach (var item in entites)
                    {
                        StudentDTO student = new StudentDTO
                        {
                            StudentId = item.StudentId,
                            FirstName =item.FirstName,
                            LastName = item.LastName,



                        };

                        list.Add(student);

                    }

                    return list;

                }
                catch (Exception ex)
                {
                    return null;
                    
                }

            }
        }

        public StudentDTO Save(StudentDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    obj.CreatedDate = DateTime.Now;
                    obj.RecordStatusId = Convert.ToByte(Enums.RecordStatus.Aktif);
                    var entity = Mapper.Map<StudentDTO, Student>(obj);
                    var student = uow.Students.Save(entity);

                    uow.Commit();

                    return Mapper.Map<Student, StudentDTO>(student);


                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return null;
                }

            }
        }

        public bool Update(StudentDTO obj)
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    var entity = Mapper.Map<StudentDTO, Student>(obj);
                    uow.Students.Update(entity);

                    return uow.Commit();


                }
                catch (Exception ex)
                {
                    uow.RollBack();
                    return false;
                }
            }
        }
    }
}
