using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class For
    {
        static void Main(string[] args)
        {
            int i;
            for( i = 0; i<=5; i++)
            {
                Console.WriteLine("출력 " +i);
            }
            Console.WriteLine(i);

            for (i = 5; i >=0 ; i--)
            {
                Console.WriteLine("출력 " + i);
            }
            Console.WriteLine();

            //두번째꼐 더 빠르다


            /* 무한 루프
            for (;;) {
                Console.WriteLine("출력");
            }
            */

        }
    }
}


/*
 * 
 * 
 * */