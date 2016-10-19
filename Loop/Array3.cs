//2차원 배열

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Arrays3
    {
        static void Main(string[] args)
        { 
            //input
            Console.WriteLine("NxM 배열을 생성합니다.");
            Console.Write(" N ? ");
            int N = int.Parse(Console.ReadLine());
            Console.Write(" M ? ");
            int M = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            char[,] ca = new char[N, M];

            //처리
            char c = 'a';
            for (int i = 0; i < ca.GetLength(0); i++)   //index = ca.GetLength(0)-1 !!
            {
                for (int j = 0; j < ca.GetLength(1); j++)
                {
                    ca[i, j] = (char)c;   //형변환한다!!

                    if (c == 'z') { c = 'a'; }
                    else { c++; }   
                }
            }

            //output
            for (int i = 0; i < ca.GetLength(0); i++)
            {
                for (int j = 0; j < ca.GetLength(1); j++)
                {
                    Console.Write(ca[i, j] + " " );     //int배열로 했으면 (char)로 형변환해줄것
                }
                Console.WriteLine();
            }

            //apple array~~
            Console.WriteLine();
            char[,] ca1= new char[N, M];

            //처리 & output
            char[] apple = { 'A', 'p', 'p', 'l', 'e','.' };
           int count = 0;
            for (int i = 0; i < ca.GetLength(0); i++)
            {
                for (int j = 0; j < ca.GetLength(1); j++)
                {
                    ca[i, j] = apple[count];

                    Console.Write("{0,3:c}", ca[i, j]);   //output

                    if (count == apple.GetLength(0)-1 )
                    {
                        count = 0;
                    }
                    else {
                        count++;
                    }
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