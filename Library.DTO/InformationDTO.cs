using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
   public class InformationDTO :IEntity
    {

        public DateTime EndDate { get; set; }
        public int LateDays { get; set; }
        public int NumberOfBooks { get; set; }
        public Decimal DailyPenalty { get { return 10; } }
        public decimal TotalAmount { get { return DailyPenalty * LateDays; } }
    }
}
