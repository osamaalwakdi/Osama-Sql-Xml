using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string CustName { get; set; }
        public string CustEmail { get; set; }
        public int GuestNo { get; set; }
        public DateTime InDate { get; set; }
        public DateTime OutDate { get; set; }
        public string RoomType { get; set; }
    }
}
