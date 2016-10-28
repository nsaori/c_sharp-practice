//p.517 Linq

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasic
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()      //자동 ToString 호출 되도록
        {
            return Name + " : " + Price + "원";
        }
    }
    class LinqProduct
    {
        static void Main(string[] args)
        {
            List<Product> input = new List<Product>();
            input.Add(new Product("감자", 500));
            input.Add(new Product("사과", 700));
            input.Add(new Product("고구마", 400));
            input.Add(new Product("배추", 600));
            input.Add(new Product("상추", 300));

            var output = from item in input
                         where item.Price >= 500
                         orderby item.Name ascending
                         select item;

            foreach (var item in output)
            {
                Console.WriteLine(item);  //자동 ToString 호출 되도록
            }
        }
    }
 }

