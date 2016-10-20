//ch5 p.189 Class start
//20161019
//reference 참조

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassUses
{
    class Car{  //car.cs(class file 따로) 로 만들어도 된다.
        //data, 변수
        public string name;
        public int number;
        public DateTime inTime;
        public DateTime outTime;

        //logic, method
        public void SetInTime() {
            this.inTime = DateTime.Now;
        }
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
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
