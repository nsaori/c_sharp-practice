using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Product : IComparable
    {
        public string Name{ get; set; }        //prp + tab + tab
        public int Price { get; set; }

        public int CompareTo(object obj)  //정렬할 떄 규칙을 준다
        {
            //return Price.CompareTo((obj as Product).Price);  // 오른차순
            //return (obj as Product).Price.CompareTo(Price);     //내린자순
            //return Name.CompareTo((obj as Product).Name);  // 오른차순
            //return (obj as Product).Name.CompareTo(Name);   //내린자순
            ///*
            int su = Name.CompareTo((obj as Product).Name); //이름이 같은 것은 가격으로 정렬한다
            if (su != 0)
            {
                return su;
            }
            else
            {
                return Price.CompareTo((obj as Product).Price);
            }
           // */
        }

        /*
        public int CompareTo(object obj)  //내용이 비어있음
        {
           throw new NotImplementedException();
        }
        */
        public override string ToString()
        {
            return Name + " : " + Price+"원";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //1.polymorphism define

            //IComparable c = new IComparable();  //interface 객체생선은 안된다.
            IComparable c = new Product();
            //((Product)c).Name = "고구마";
            //((Product)c).Price = 1500;
            if (c is Product)
            {
                Product p = (Product)c;
                p.Name= "고구마";
                p.Price = 1500;
            }
            Console.WriteLine(c);
            Console.WriteLine(c.ToString());
            Console.WriteLine();

            /*List<Product> list = new List<Product>()
            {
                new Product() {Name = "고구마", Price = 1500 },
                new Product() {Name = "사과", Price = 2400 },
                new Product() {Name = "바나나", Price = 3000 },
                new Product() {Name = "바나나", Price = 1000 },
            };
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();       
            */

            //2.polymorphism array
            IComparable[] ca = new IComparable[4];
            ca[0] = new Product { Name = "고구마", Price = 1500 };
            ca[1] = new Product() { Name = "사과", Price = 2400 };
            ca[2] = new Product() { Name = "바나나", Price = 3000 };
            ca[3] = new Product() { Name = "바나나", Price = 1000 };
            for (int i = 0; i < ca.Length; i++)
            {
                Console.WriteLine(ca[i]);
            }
            Console.WriteLine();
        }
    }
}
