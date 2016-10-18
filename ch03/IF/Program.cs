using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 입력: ");
            // string sinput = Console.ReadLine();
            // int input = int.Parse(sinput);
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine(input + "은(는) 짝수입니다");
            }
            else // if (input % 2 == 1)
            {
                Console.WriteLine(input + "은(는) 홀수입니다");
            }
            /*
            Console.WriteLine(1 % 2);   //1; 홀수
            Console.WriteLine(2 % 2);   //0;짝수
            Console.WriteLine(3 % 2);   //1; 홀수
            Console.WriteLine(4 % 2);   //0;짝수
            Console.WriteLine(5 % 2);   //1; 홀수
            Console.WriteLine(6 % 2);   //0;짝수
            */
        }
    }
}
