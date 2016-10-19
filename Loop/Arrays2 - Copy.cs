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

            char[,] ca = new char[N, M];

            //처리
            int c = 'a';
            for (int i = 0; i < ca.GetLength(0); i++)
            {
                for (int j = 0; j < ca.GetLength(1); j++)
                {
                    ca[i, j] = (char)c;

                    if(c =='z') {
                        c = 'a'-1;
                    }
                    c++;
                }
            }

            //output
            for (int i = 0; i < ca.GetLength(0); i++)
            {
                for (int j = 0; j < ca.GetLength(1); j++)
                {
                    Console.Write(ca[i, j] + " " );
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