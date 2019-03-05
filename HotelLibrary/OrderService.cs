using System;
using System.Collections.Generic;
using System.Text;

namespace HotelLibrary
{
    public class OrderService
    {
        public int Id { get; set; }
        public List<Service> MyProperty { get; set; } = new List<Service>();
        public int Amount { get; set; }
        public DateTime TimUse { get; set; }
        public decimal TotalFee { get; set; }
    }
}
