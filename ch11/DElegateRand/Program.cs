//p.482 delegate; 변수처럼 사용하는 method다.
/*sort--
 * products.Sort(SortWithPrice);
 private static int SortWithPrice(Product x, Product y){return x.Price.CompareTo(y.Price);}
        */
// ->하나로 '무명 delegate; p.486
//   products.Sort((x, y) => x.Price.CompareTo(y.Price));  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DElegateRand
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price) {
            Name = name;
            Price = price;
        }
        public override string ToString() {
            return Name + " : " + Price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("감자", 500));
            products.Add(new Product("사과", 700));
            products.Add(new Product("고구마", 400));
            products.Add(new Product("배추", 600));
            products.Add(new Product("상추", 300));

            // products.Sort(SortWithPrice); //변수??  -- ???함수호출;SortWithPrice()???

            //무명 delegate p.486
            products.Sort((x, y) => x.Price.CompareTo(y.Price));  

            foreach (var item in products)
            {
                Console.WriteLine( item );  //자동 ToString 호출 되도록
            }
        }
        /*
        private static int SortWithPrice(Product x, Product y) //변수
        {
            return x.Price.CompareTo(y.Price);  //오른자순
        }
        */

    }
}
