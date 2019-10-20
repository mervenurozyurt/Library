using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
   public  class RecordStatusDTO :IEntity
    {

        public byte RecordStatusId { get; set; }
        public string RecordStatusName { get; set; }

    }
}
