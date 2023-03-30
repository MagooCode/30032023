using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Order
    {
        public int No { get; set; }
        public int ProductCount { get; set; }
        public int TotalAmount { get; set; }

        public Order(int no, int productCount, int totalAmount)
        {
            No = no;
            ProductCount = productCount;
            TotalAmount = totalAmount;
        }
    }
}
