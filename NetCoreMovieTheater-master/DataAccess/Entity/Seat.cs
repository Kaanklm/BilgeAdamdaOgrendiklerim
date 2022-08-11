using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Seat:BaseEntity
    {
        public string SeatNo { get; set; }
        public List<SaloonSeat> SaloonSeats { get; set; }
    }
}
