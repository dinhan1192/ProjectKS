using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class Position
    {
        public int Id { get; set; }

        public string NamePosition { get; set; }

        public List<Employee> employees { get; set; }
    }
}
