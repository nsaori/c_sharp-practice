//p.340 stsatic(class) 변수 상속
//p.346 new,virtual,overriding keywords
//virtual,overriding keywords  ; 같이 쓴다!!
//new ; 부모께 쓴다!   
//      그래도 ((Parent)child).Method(); 이렇게 안하면 그냥 자식 자신을 호출한다.
//virtual ; 나는 부모다!
//overriding ; 오버라이딩한다! 난 자식 자기 껄 쓰겠다!
//   ((Parent)child).Method(); 이렇게 해도 자식자신이 호출된다.

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
        public virtual void Method1() { Console.WriteLine("부모 method1"); }  //virtual
    }
     class Child : Parent
    {
        public static int CountChild() {return ++count; }

        protected new string val = "hiding";        //new keyword ; hide할 것을 분명하게--
        public new void Method() { Console.WriteLine("자식 method"); }
        public override void Method1() { Console.WriteLine("자식 method1"); }     //overriding
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent pc = new Child();
            pc.Method();
            pc.Method1();
            if (pc is Child) { ((Parent)pc).Method(); }   //pc as Parent
            Console.WriteLine();

            Child child = new Child();
            Parent parent = new Parent();
            child.Method();             //자식 method
            parent.Method();            //부모 method
            ((Parent)child).Method();   //부모 method
            Console.WriteLine();

            child.Method1();        //자식 method
            parent.Method1();       //부모 method
            ((Parent)child).Method1(); //자식 method
            Console.WriteLine();

            Class1 c = new Class1();

            Parent.CountParent();
            Child.CountChild();
            Console.WriteLine(Parent.count + "\t" + Child.count);
        }
    }
}
