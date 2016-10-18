using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0405
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < ((15-(i*2-1))/2 ); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i*2-1 ; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < ((15 - (i * 2 - 1)) / 2); j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
