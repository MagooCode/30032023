using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0703_2_._0.Models
{
    public class Product
    {
        public short No;
        public string Name;
        public int Price;
        public int Count;

        public Product(short No, string Name, int Price)
        {
            this.No = No;
            this.Name = Name;   
            this.Price = Price;
        }



    }
}
