//20161025 p.355 다형성 ; abstract  추상
//     -> 꼭 상속,overrideing하라
// 다형성에 써먹는다
//abstract, interface = new하서 객체를 못만든다
//      spuer 보다 spere class가 될떄 
//absstract class는 abstract method가 있든없든 무관
//abstract method가 있는 class는 absstract class이어야 된다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Parent
    {
        //public virtual void Test() { Console.WriteLine("Parent.Test()"); }
        public abstract void Test(); //abstract - > 내용 {} 이 없어애 된다.
}
    class Child : Parent
    {
        public override void Test() { Console.WriteLine("Child.Test()"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Parent p = new Parent();     //abstract땜에 안된다.
            Parent p = new Child();         //polymorphism 적용
            p.Test();       //Parent.Test()
                            // overriding/abstract  -> Child.Test()

            Child c = new Child();
            c.Test();       //Child.Test()
        }
    }
}
