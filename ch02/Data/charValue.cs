using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class charValue
    {
        static void Main(string[] args) {
            char a = 'a';
            char b = 'b';

            Console.WriteLine(a);
            Console.WriteLine("a의 askiicode:   " + (int)a);
            Console.WriteLine(b);
            Console.WriteLine("b의 askiicode:   " + (int)b);
            Console.WriteLine("'a'+'b'=>  " + (a + b));
            Console.WriteLine("'a'-'b'=>  " + (a - b));
            Console.WriteLine("'a'*'b'=>  " + (a * b));
            Console.WriteLine("'a'/'b'=>  " + (a / b));
            Console.WriteLine("'a'%'b'=>  " + (a % b));


        }
    }
}
