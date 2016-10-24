//20131024 saori ch7 상속-inheritance
// 접근 지정자 p.323
//모든 클래스의 최상의 클래스는 object class. p.331
// : base()

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal //:Object  //sperClass; 생선자,public한 methods
    {
        public int Age { get; set; }
        public Animal(int age) {
            Age = age;
        }
        public Animal():base() {
            Age = 0;
            Console.WriteLine("Animal() constractor ");
        }
        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }
        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잤습니다.");
        }

        private void Private() { }
        protected void Protected(){ }
        public void Public() { }
        public void TestA() {
            Private();
            Protected();
            Public();
        }
    }
    class Dog : Animal {
        //public int Age { get; set; }
        public string Color{ get; set; }

        public Dog() {
            Age = 0;
            Console.WriteLine("Dog() constractor");
            //Color = "";
        }

        /*public void Eat() {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잤습니다.");
        }
        */
        public void Bark()
        {
            Console.WriteLine("왈오라 짓습니다.");
        }
        public void TestD()
        {
            // Private();    //private땜에 딴 클래스에선 안된다.
            Protected();//딴 클래스지만 파샌 클래스껀 된다.
            Public();
        }
    }
    class Cat: Animal
    {
        //public int Age { get; set; }
        public Cat() {
            Age = 0;
            Console.WriteLine("Cat() constractor");
        }
        /*
        public void Eat()
        {
            Console.WriteLine("냠냠 먹습니다.");
        }

        public void Sleep()
        {
            Console.WriteLine("쿨쿨 잠을 잤습니다.");
        }*/
        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();
            //List<Cat> cats = new List<Cat>();

            dogs.Add(new Dog());
            dogs.Add(new Dog());
            foreach (var item in dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
                Console.WriteLine();
            }Console.WriteLine();

            List<Cat> cats = new List<Cat>() { new Cat(), new Cat() };
            //cats.Add(new Cat());
            //cats.Add(new Cat());
            foreach (var item in cats)
            {
                item.Eat();
                item.Sleep();
                item.Meow();
                Console.WriteLine();
            }
            Console.WriteLine();

            Dog d = new Dog();
            //d.Private();
            //d.Protected();    //Program class는 같은 클래스도 아니고 파생 클래스도 아니다.
            d.Public();
            Console.WriteLine(d);   //Inheritans.Dog
            Console.WriteLine(d.ToString());     //Inheritans.Dog
            Console.WriteLine();

            string s = "홍길동";
            Console.WriteLine(s);   //홍길동
            Console.WriteLine(s.ToString());     //홍길동
            Console.WriteLine();

            //p..331
            List<Object> list = new List<object>(); //모든 클래스의 최상의 클래스는 object class.
            list.Add(new Dog());
            list.Add(new Cat());
            list.Add(123);
            list.Add(3.14);
            foreach (var item in list)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.ToString());
            }
        }
    }
}
