using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH0405
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 7; i++)
            {
                for (int j = 0; j < 7 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');

                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.Write('\n');

            }
        }
    }
}
