using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AABooking.Shared.Domain
{
    public class Restaurant
    {
        public int ResId { get; set; }
        public string ResName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public int CusId { get; set; }
        public Customer Customer { get; set; }
    }
}
