using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class Room
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public int Floor { get; set; }

        public string Status { get; set; }

        public int MaxPeople { get; set; }
    }
}
