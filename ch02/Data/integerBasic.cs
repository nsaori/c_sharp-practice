using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class integerBasic
    {
        static void Main(string[] args) {
            Console.WriteLine(1 + 2);
            Console.WriteLine(10 - 3);
            Console.WriteLine(3 * 3);
            Console.WriteLine(10 / 3);
            Console.WriteLine(10.0 / 3);
            Console.WriteLine(10 % 3 + "\n");

            Console.WriteLine(" \\");   // \
            Console.WriteLine("\"");    // "
            Console.WriteLine("\ttab  \n newline \n");    // \t \n

            // Console.WriteLine((int)a);
            Console.WriteLine('a');
            Console.WriteLine((int)'a');

            Console.WriteLine("한빛" + "아카데미");
            Console.WriteLine("한빛" + "\t" + "아카데미");
            Console.WriteLine('a' + 'a');   //숫자가 나온다
            Console.WriteLine("a" + "a");   //문자열이 나온다
            Console.WriteLine("hello"[3] + "\n");   //3번째 문자출력

            Console.WriteLine("A" + 10 + 20);   //"A10"+20  //A1020  ; over loading
            Console.WriteLine(10 + 20 + "A");   //30+"A"   //30A


        }
    }
}
