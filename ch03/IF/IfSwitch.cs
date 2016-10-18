using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    class IfSwitch
    {
        static void Main(string[] args) {
            Console.Write("내 점수응요? ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 90)
            {
                Console.WriteLine("A");
            }
            else if (n >= 80)
            {
                Console.WriteLine("B");
            }
            else if (n >= 70)
            {
                Console.WriteLine("C");
            }
            else if (n >= 60)
            {
                Console.WriteLine("D");
            }
            else {
                Console.WriteLine("F");
            }
            /*
            switch (n) {
                case 100:
                case 99:
                case 98:
                case 97:
                case 96:
                case 95:

            }
            */
        }
    }
}
