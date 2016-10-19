using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Arrys
    {
        static void Main(string[] args)
        {
            //1.선언
            //int[] ia;
            //2.생선
            //ia = new int[3];

            //1`+2
            int[] ia = new int[3];
            /*
            //3.alloc
            ia[0] = 10;
            ia[1] = 20;
            ia[2] = 30;
            */
            int[] ai = { 10,20,30};
            for (int i = 0; i < ai.Length; i++) {
                Console.WriteLine("ai[" + i + "] = " + ai[i]);
            }
            Console.WriteLine();

            foreach (var item in ai)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            int[] intArray = new int[10];
            Console.WriteLine(intArray[0]);
            foreach (int n in intArray) {
                Console.WriteLine(n);
            }

            double[] doublrArry = new double[10];
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine();

            char[] charArry = new char[10];
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine();

            string[] stringArry = new string[10];
            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine();

        }
    }
}


/*
 * 
 * 
 * */