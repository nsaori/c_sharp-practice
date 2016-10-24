//p.340 stsatic(class) 변수 상속
//p.346 new,virtual,overriding keywords

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //p.340  
   class Parent {
        public static int count = 0;
        public static int CountParent() { return ++count; }

        protected int val = 273;
        public void Method() { Console.WriteLine("부모 method"); }
    }
     class Child : Parent
    {
        public static int CountChild() {return ++count; }

        protected string val = "hiding";
        public void Method() { Console.WriteLine("자식 method"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            Parent parent = new Parent();
            child.Method();
            parent.Method();
            ((Parent)child).Method();
            Console.WriteLine();
            

            Class1 c = new Class1();

            Parent.CountParent();
            Child.CountChild();
            Console.WriteLine(Parent.count + "\t" + Child.count);
        }
    }
}
