using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AABooking.Shared.Domain
{
    public class Customer
    {
        public int CusId { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int ResId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservations Reservations { get; set; }
    }
}
