//20161020 saori
//ch06 p.270 Constructor (same name with Class, no returntype,)-instance변수 초기화 위해서 있다
// instance(local)변수와 parameter는 이름을 같이 한다
//constructor overloading

// Class A ->변수a 1개 ->생성자2개;(),(a)
//                 2개 ->생성자5개:(),(a),(b),(a,b),(b,a)
//                 3개 ->(),(a),(b),(c),(a,b),(b,a),(a,c),(c,a),(b,c),(b,c),(a,b,c)...
//                 n개 -> 1+n*n

//생성자 만들 때(overloading) 최소 3가지 overloading한다(parameter의 1.아무것도 없는 것(상속떔),2.inctance변수 다들어가는것, 3.필수항목)

//생성자 -> private ; (멤버가 다 static일때, 팩토리 메서드 패턴에서 메서드로만 인스턴스를 생성하게 할 때, single...객체를 하나만 생성할 떄..?)
//  ex;Math Class
//  static 붙일 수도 있다

// default 생성자는 하나도 생성자가 하나도 없을 떄만 자동 생성된다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Product
    {
        public static int counter = 0;
        public int id;
        public string name;
        public int price;

        public Product()             //constructor overloading; 매개변수 아무것도 없는 것
        {         
            Console.WriteLine("Product() constructor가 호출이 되었습니다.");
        }           
        public Product(string name,int price)   //constructor overloading; 다들어가는 것
        {
            Console.WriteLine("public Product(string name,int price) constructor가 호출이 되었습니다.");
            Product.counter++;
            this.id = Product.counter;
            this.name = name;
            this.price = price;
        }
        public Product(string name)         //constructor overloading; 필수 항복이 들어가는것
        {  
            Console.WriteLine(" public Product(string name)   constructor가 호출이 되었습니다.");
            Product.counter++;
            this.id = Product.counter;
            this.name = name;
            this.price = 0;
        }
        ~Product()
        {
            Console.WriteLine(name + "  ~Product() 소멸자가 호출이 되었습니다.");
        }
        public string ToString() {
            return id + "\t" + name + "\t" + price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product(); //default 생성자
            Product.counter++;
            p1.id = Product.counter;
            p1.name = "양파";
            p1.price = 500;
            Console.WriteLine(p1.id + "\t" + p1.name + "\t" + p1.price);

            Product.counter++;
            Product p2 = new Product()
            {
                id = Product.counter,
                name = "대파",
                price = 300
            };
            Console.WriteLine(p2.ToString());

            Product p3 = new Product("파", 200);
            Console.WriteLine(p3.ToString());

            Product p4 = new Product("피망");
            Console.WriteLine(p4.ToString());

            Product p5 = new Product("감자");
            p5.price = 2000;
            Console.WriteLine(p5.ToString());

            Product p6 = new Product("고구마",3000);
            Console.WriteLine(p6.ToString());

            Console.WriteLine(Product.counter + "개 생성되었습니다.");
            Console.WriteLine();
        }
    }
}
