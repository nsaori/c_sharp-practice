//20131024 saori ch7 상속-inheritance
// 접근 지정자 p.339
// : base()
//constructor overloading -생성자 오버로딩

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parent {
        public Parent() //:base() //:base() 있어도 없어도 결과는 동일하다.
        {
            Console.WriteLine("parent constructor");
        }
        public Parent(int i) : base() //constructor overloading
        {
            Console.WriteLine("parent(int i) constructor");
        }
        public Parent(string s) : base() //constructor overloading
        {
            Console.WriteLine("parent(string s) constructor");
        }
    }
    class Child : Parent {
        public Child() //: base()  //:base() 있어도 결과는 동일하다.
        {
            Console.WriteLine("child constructor");
        }
        public Child(int i) : base(i)  //constructor overloading //해당 부모()도 호출된다
        {
            Console.WriteLine("child(int i) constructor");
        }
        public Child(string s) : base(s) //constructor overloading //해당 부모()도 호출된다  base(s)없으면 default부모가 호출된다.
        {
            Console.WriteLine("child(string s) constructor");
        }

    }

    class ConstructorSequence
    {
        static void Main(string[] args)
        {
            Child c = new Child();
            Console.WriteLine();

            Child c1 = new Child(123);
            Console.WriteLine();

            Child c2 = new Child("홍길동");
            Console.WriteLine();
        }
    }
}
