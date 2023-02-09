using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AABooking.Shared.Domain
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        public DateTime ReservationTime { get; set; }
        public DateTime ReservationDate { get; set; }
        public int ResId { get; set; }
        public Restaurant Restaurants { get; set; }
        public int CusId { get; set; }
        public Customer Customer { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
    }
}
