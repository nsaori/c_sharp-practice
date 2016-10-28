using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindForm
{
    class Product
    {
        public string Name { get; set; }    //prop tab tab
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public Product()
        {
            Name = "-" ;
            Price = 0;
        }
    }
}
