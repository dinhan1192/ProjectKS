using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class Booking
    {
        public int Id { get; set; }
        public Customer customer { get; set; }
        public Employee employee { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public decimal TotalRoomFee { get; set; }
    }
}
