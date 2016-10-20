//ch5 p.207 Class start  .파일 따로,
//20161019
//class 생성3가지 1. 프로그램 안에, 2.클래스, 3. 안에파일 따로
//class name잘 잡아야 한다.!! 
//Console.WriteLine(Math.Abs(-3));   //class name잘 잡아야 한다.!! //여기서 Math는 그 Math class가아닌 위에 만든게 되서 abs가 안된다.(위 클레스엔 아무것고 없기에)
  //          Console.WriteLine(System.Math.Abs(-3)); //앞에 System.  를 붙어주면 사용가능


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassUses
{
    class Math {

    }

    class Program2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Math.Abs(-3));   //class name잘 잡아야 한다.!! //여기서 Math는 그 Math class가아닌 위에 만든게 되서 abs가 안된다.(위 클레스엔 아무것고 없기에)
            Console.WriteLine(System.Math.Abs(-3)); //앞에 System.  를 붙어주면 사용가능

            MyClass m1 = new MyClass();
            m1.name = "마이클레스";
            m1.Method();
            Console.WriteLine();

            int ii = 123;
            Car c1 = new Car();   //c1는 주소값을 가리킨다(car객체의 주소값)
            Console.WriteLine(c1.name);
            Console.WriteLine(c1.number);
            Console.WriteLine(c1.inTime);
            Console.WriteLine(c1.outTime);
            Console.WriteLine();

            c1.name = "마이카";
            c1.number = 1004;
            c1.SetInTime();
            Thread.Sleep(2 * 1000);
            c1.SetOutTime();

            Console.WriteLine(c1.name);
            Console.WriteLine(c1.number);
            Console.WriteLine(c1.inTime);
            Console.WriteLine(c1.outTime);
            Console.WriteLine();

            Car c2 = new Car();
            c2.name = "your car";
            c2.number = 1007;
            c2.SetInTime();
            Thread.Sleep(1 * 1000);
            c2.SetOutTime();

            Console.WriteLine(c2.name);
            Console.WriteLine(c2.number);
            Console.WriteLine(c2.inTime);
            Console.WriteLine(c2.outTime);
            Console.WriteLine();
            Console.WriteLine("------------------------------");

            c1 = c2;   //c1도 c2를 가리킨다.
            Console.WriteLine(c1.name);
            Console.WriteLine(c1.number);
            Console.WriteLine(c1.inTime);
            Console.WriteLine(c1.outTime);
            Console.WriteLine();

        }
    }

   
}
