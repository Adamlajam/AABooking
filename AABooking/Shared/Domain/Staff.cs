using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AABooking.Shared.Domain
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string Name { get; set; }
        public string Restaurant { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}