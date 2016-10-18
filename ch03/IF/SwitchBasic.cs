using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    class SwitchBasic
    {
        static void Main(string[] args) {
            Console.Write("숫자 입력: ");
            int input = int.Parse(Console.ReadLine());

            switch (input % 2) {

                case 0:
                    Console.WriteLine(input + " : 짝수");
                    break;

                //case 1:
                default:
                    Console.WriteLine(input + " : 홀수");
                    break;
            }

        }
    }
}
