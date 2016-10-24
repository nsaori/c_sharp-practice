//201024 polymorphism -다형성
//p.329


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "홍길동";
            Console.WriteLine(s);   //홍길동
            Console.WriteLine(s.ToString());    //홍길동  //System.String??   -> overwriteing
            Console.WriteLine();

            Dog d = new Dog();
            Console.WriteLine(d);   //Polymorphism.Dog
            Console.WriteLine(d.ToString());    //Polymorphism.Dog   // ->overwriting
        }
    }
}


/*
 * .ToString()  //namespace.name
 * */