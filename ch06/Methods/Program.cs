//20161020 saori
//ch06 p.252 Method  (instaceMethod & static(class)Method) ,overloading(p.261
//object arrayted program
//instance method; 반드시 객체를 생성해야 된다. if using 'static', needless - odj
//class(static) method; use without creating objects
//  passibl to use only static methods,변수,local 변수, args(parameter로 들어오는 변수)
//  inpassible to use instance methods, 변수(these has relationship with objects.)before creating a object, 

//overloading ; same name but diffelent parameter(1.type,2.개수,3.order)

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
        //class(static) method;  use without creating objects
        public static int Abs(int input)
        {
            Console.Write("Abs(int) ");
            if (input < 0) { return -input;
            } else { return input; }
        }
        //overloading 다중정의,중복정의
        public static double Abs(double input)
        {
            Console.Write("Abs(double) ");
            if (input < 0){ return -input; }
            else { return input;  }
        }
        public static long Abs(long input)
        {
            Console.Write("Abs(long) ");
            if (input < 0) { return -input; }
            else { return input; }
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
            Console.WriteLine();
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
            Console.WriteLine();
            Console.WriteLine(Test.Abs(52));
            Console.WriteLine(Test.Abs(-132));
            Console.WriteLine(Test.Abs(52.123));
            Console.WriteLine(Test.Abs(-132.0));
            Console.WriteLine(Test.Abs(52L));
            Console.WriteLine(Test.Abs(-132L));
        }
    }
}
