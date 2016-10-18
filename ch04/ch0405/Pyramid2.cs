using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
                for (int i = 0; i <= 13; i = i + 2) //i=0
                {
                    for (int j = 0; j < (13 - i) / 2; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

   