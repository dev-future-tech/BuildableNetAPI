using System;

namespace BuildableNetAPI
{
    public class CustomerBill
    {
        public int CustomerId { get; set; }
        public decimal Cost { get; set; }
        public DateTime DueDate { get; set; }
    }
}