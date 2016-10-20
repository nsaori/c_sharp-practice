//20161020 saori
//ch06 p.252 Method
//object arrayted program
//instance method; 반드시 객체를 생성해야 된다. if using 'static', needless - odj

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Test
    {
        //instance method; 반드시 객체를 생성해야 된다. if using 'static', needless - odj
        public int Power(int x) {  
            return x * x;
        }
        public int Multi(int x, int y)
        {
            return x * y;
        }
        public void Print() {
            Console.WriteLine("Print Method가 호출되었습니다.");
        }
        public int Sum(int min, int max) {
            int total = 0;
            for (int i = max; i >= min; i--) {
                total += i;
            }
            return total;
        }
        public long Multiply(int min, int max) {
            long total = 1;
            for (int i = max; i >= min; i--)
            {
                total *= i;
            }
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();   //t1 - refarence 줒소값이 들어사있다.
            //using inctance methods
            Console.WriteLine(t1.Power(10));
            Console.WriteLine(t1.Power(20));

            Console.WriteLine(t1.Multi(52, 173));
            Console.WriteLine(t1.Multi(103, 32));

            t1.Print();
            t1.Print();
            t1.Print();

            Console.WriteLine(t1.Sum(1, 2));
            Console.WriteLine(t1.Sum(1, 3));
            Console.WriteLine(t1.Sum(1, 10));
            Console.WriteLine(t1.Sum(1, 100));
            Console.WriteLine();

            Console.WriteLine(t1.Multiply(1, 2));
            Console.WriteLine(t1.Multiply(2, 3));
            Console.WriteLine(t1.Multiply(3, 5));
            Console.WriteLine(t1.Multiply(1, 10));
            Console.WriteLine(t1.Multiply(1, 20));
            //Console.WriteLine(t1.Multiply(1, 100));  //overflow  long < double
        }
    }
}
