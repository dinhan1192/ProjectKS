using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class Bill
    {
        public int Id { get; set; }
        public Customer customer { get; set; }
        public Booking booking { get; set; }
        public DateTime TimeCreate { get; set; }
        public decimal TotalRoomsFee { get; set; }
        public decimal TotalServicesFee { get; set; }
        public decimal TotalFee { get; set; }

    }
}
