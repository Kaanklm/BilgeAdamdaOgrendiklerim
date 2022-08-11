using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class SaloonSeat:BaseEntity
    {
        public int SaloonId { get; set; }
        public int SeatId { get; set; }

        public Saloon Saloon { get; set; }
        public Seat Seat { get; set; }
    }
}
