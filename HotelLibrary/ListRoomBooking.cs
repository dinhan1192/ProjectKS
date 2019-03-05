using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class ListRoomBooking
    {
        public int Id { get; set; }
        public Booking booking { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
