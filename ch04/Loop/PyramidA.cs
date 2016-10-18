//p163

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class PylamidA
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 10; i >=0 ; i--)
            {
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10-i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 10; i >= 0; i--)
            {
                for (int j = 10-i; j > 0; j--) { 
                    Console.Write(" ");
                }
                for (int j = i; j >= 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}


/*
 * 
 * 
 * */