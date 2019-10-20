using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DTO
{
  public  class PenaltyDTO :IEntity
    {
        public int PenaltyId { get; set; }
        public int BorrowId { get; set; }
        public decimal Penalty1 { get; set; }

        public string BorrowName { get; set; }

    }
}
