//20161020
//ch5 Class p.213~  클래스 변수 초기화
//class 변수, instance 변수

//class 변수 -> static! -> object 생성 안하고 바로 쓰기!  
//   ->사용; class이름.class변수 (Product.PI)  ;member를 만들지 말고 사용한다.(x; p1.PI xxx)
// 가능하면 static 를 안붙이는게 낫다  (utirity 등의 경우만)

//instance 변수 -> object 를 생성해야 사용 가능한다!
// Product p3 = new Product() { name = "고구마", price = 3000 };

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassUses
{
    //class를 만들 떄 기본적으로 값을 지정하지 않은다.
    //그러나 명시적으로 초기값을 줄 수 있다.
    class User {
        public string name;
        public string password;
        public string address;
        public string nphoneNumber;
        public DateTime regDate;
    }
    class Product {
        //class 변수 -> static! -> object 생성 안하고 바로 쓰기!   ->사용; class이름.class변수 (Product.PI) //가능하면 쓰지 말것기!
        public static double PI = 3.1415925;
        public static double TAX = 0.03;
        //instance 변수 -> object 를 생성해야 사용 가능한다!
        public string name = "명시적 초기화";
        public int price = 10;
    }
    class Variables
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product.PI);
            Console.WriteLine(Product.TAX);

            Product p1 = new Product();
            Console.WriteLine(p1.name + " : " + p1.price + "원");   //default value(또는 명시적초기화 값)로 초가화가 된다. fefault allocation

            p1.name = "제품명";
            p1.price = 1000;
            Console.WriteLine(p1.name + " : "+ p1.price+ "원");

            Product p2 = new Product();
            Console.WriteLine(p2.name + " : " + p2.price + "원");

            Product p3 = new Product() { name = "고구마", price = 3000 };
            Console.WriteLine(p3.name + " : " + p3.price + "원");
        }
    }
}
