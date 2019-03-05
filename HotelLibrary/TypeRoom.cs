using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class TypeRoom
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public List<Room> Rooms { get; set; }

        public decimal  Prize { get; set; }
    }
}
