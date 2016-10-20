//20161020 saori
//p.312 ch6 04
//자동 형변환(정확안 type없으면~)      overloading된 method(parameter: diffelent type,instance,order)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0604
{
    class Program
    {
        static int Test(int A) {return 10; }
        static int Test(long A) { return 20;}
        static int Test(float A) { return 30; }
        static int Test(double A) {return 40; }

        static void Main(string[] args)
        {
            Console.WriteLine(Test(52273));     //10   -> int형은 long,float,double형 다 들어갈 수 있다.(장동형변환)
            Console.WriteLine(Test(52273L));    //20
            Console.WriteLine(Test(52.273F));   //30
            Console.WriteLine(Test(52.273));    //40
        }
    }
}
