using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
    public class BookDTO :IEntity
    {

        public int BookId { get; set; }
        public string BookName { get; set; }
        public byte GenreId { get; set; }
        public string Author { get; set; }
        public System.DateTime PublishDate { get; set; }
        public int UnitsInStock { get; set; }
        public byte RecordStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }

        public string GenreName { get; set; }
        public string RecordStatusName { get; set; }

        public string Display { get { return BookName + " " + UnitsInStock; } }
    }
}
