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
    public class DefinitionService :BaseService
    {
        public List<GenreDTO> GetGenres()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entities = uow.Genres.List();

                List<GenreDTO> list = new List<GenreDTO>();

                foreach (var item in entities)
                {
                    list.Add(Mapper.Map<Genre, GenreDTO>(item));
                }

                return list;
            }
        }

        public List<RecordStatusDTO> GetRecordStatuses()
        {
            using (UnitOfWork uow = new UnitOfWork())
            {
                var entities = uow.RecordStatuses.List();

                List<RecordStatusDTO> list = new List<RecordStatusDTO>();

                foreach (var item in entities)
                {
                    list.Add(Mapper.Map<RecordStatus, RecordStatusDTO>(item));
                }

                return list;
            }

        }


    }
}
