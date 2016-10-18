using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    class SwitchMonth
    {
        static void Main(string[] args)
        {
            Console.Write("몇 월? ");
            int manth = int.Parse(Console.ReadLine());

            switch (manth)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울 ");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("가을");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("겨울");
                    break;
                default:
                    Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
                    break;
            }
        }
    }
}

