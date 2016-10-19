//ch5 p.189 Class start
//20161019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassUses
{
    class Car{  //car.cs 로 만들어도 도니다.
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
            int i1 = 123;
            Car c1 = new Car();
            Console.WriteLine(c1.name);
            Console.WriteLine(c1.number);
            Console.WriteLine(c1.inTime);
            Console.WriteLine(c1.outTime);
            Console.WriteLine();

            c1.name = "마이카";
            c1.number = 1004;
            c1.SetInTime();
            Thread.Sleep(1 * 1000);
            c1.SetOutTime();

            Console.WriteLine(c1.name);
            Console.WriteLine(c1.number);
            Console.WriteLine(c1.inTime);
            Console.WriteLine(c1.outTime);
            Console.WriteLine();
            
        }
    }
}
