using System;
using System.Collections.Generic;
using System.Text;

namespace OrderTaker.SharedObjects
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
