using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class AssignmentOperator
    {
        static void Main(string[] args)
        {
            int a = 5;
            a = a + 10;
            Console.WriteLine(a); //15
            a += 10;
            Console.WriteLine(a); //15+10 = 25
            Console.WriteLine();

            string s = "hello";
            s = s + " world";
            Console.WriteLine(s);
            s += " ^^";
            Console.WriteLine(s);
            Console.WriteLine();


        }  
    }
}
