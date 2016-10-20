//20161020 ch0607 constructor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0607
{
    class A
    {
        public A() {
            Console.WriteLine("A의 생성자");
        }
        ~A() {
            Console.WriteLine("A의 소멸자");
        }
    }
    class B : A
    {
        public B()
        {
            Console.WriteLine("B의 생성자");
        }
        ~B()
        {
            Console.WriteLine("B의 소멸자");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new B();
        }
    }
}
