using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0304
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("태어난 년도는요? ");
            int year = int.Parse(Console.ReadLine());

            switch (year%12) {
                case 0:
                    Console.WriteLine(" 원숭이 띠입니다.");
                    break;
                case 1:
                    Console.WriteLine(" 닭 띠입니다.");
                    break;
                case 2:
                    Console.WriteLine(" 개 띠입니다.");
                    break;
                case 3:
                    Console.WriteLine(" 돼지 띠입니다.");
                   break;
                case 4:
                    Console.WriteLine(" 쥐 띠입니다.");
                    break;
                case 5:
                    Console.WriteLine(" 소 띠입니다.");
                    break;
                case 6:
                    Console.WriteLine(" 범 띠입니다.");
                    break;
                case 7:
                    Console.WriteLine(" 토끼 띠입니다.");
                    break;
                case 8:
                    Console.WriteLine(" 용 띠입니다.");
                    break;
                case 9:
                    Console.WriteLine(" 뱀 띠입니다.");
                    break;
                case 10:
                    Console.WriteLine(" 말 띠입니다.");
                    break;
                case 11:
                    Console.WriteLine(" 양 띠입니다.");
                    break;

            }
        }
    }
}
