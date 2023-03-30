using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0703_2_._0.Models
{
    public class Book : Product
    {
        public string Genre;

        public Book(short No, string Name, int Price, string Genre) : base(No, Name, Price)
        {
            this.Genre = Genre;
        }
    }
}
