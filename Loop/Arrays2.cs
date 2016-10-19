//2차원 배열

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Arrays2
    {
        static void Main(string[] args)
        { 
            //input
            Console.WriteLine("NxM 배열을 생성합니다.");
            Console.Write(" N ? ");
            int N = int.Parse(Console.ReadLine());
            Console.Write(" M ? ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] ia = new int[N, M];   //2차원배열
            Console.WriteLine("ia.Length = " + ia.Length);  //15; 원소수
            Console.WriteLine("ia.Rank = " + ia.Rank);  //2   ;몇 차원
            Console.WriteLine("ia.GetLength(0) = " + ia.GetLength(0));  //3  
            Console.WriteLine("ia.GetLength(1) = " + ia.GetLength(1));  //5
            Console.WriteLine();
           
            //처리
            int count = 1;
            for (int i = 0; i < ia.GetLength(0); i++)
            {
                for (int j = 0; j < ia.GetLength(1); j++)
                {
                    ia[i, j] = count++;
                }
                //Console.WriteLine();
            } 
            
            //출력
            for (int i = 0; i < ia.GetLength(0); i++)
            {
                for (int j = 0; j < ia.GetLength(1); j++)
                {
                    Console.Write("ia["+i+","+j+"] = " + ia[i, j]+"\t");
                }
                //Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            /*
            for (int i = 0; i < ia.GetLength(0); i++)
            {
                for (int j = 0; j < ia.GetLength(1); j++)
                {
                    Console.Write( ia[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            */
            for (int i = 0; i < ia.GetLength(0); i++)
            {
                for (int j = 0; j < ia.GetLength(1); j++)
                {
                    Console.Write("{0,3:d}", ia[i, j]);
                }
                Console.WriteLine();
            }
            /*
            Console.WriteLine();
            for (int i = 0; i < ia.GetLength(0); i++)
            {
                for (int j = 0; j < ia.GetLength(1); j++)
                {
                    Console.Write(" {0}", ia[i, j]);
                }
                Console.WriteLine();
            }
            */

        }
    }
}


/*
 * 
 * 
 * */  