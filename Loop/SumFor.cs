//p163

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class SumFOr
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하시오: ");
            int max = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= max; i++)
            {
                sum += i;
            }
            Console.WriteLine(" 1 ~ {0} 의 합: {1}", max, sum);
            
        }
    }
}


/*
 * 
 * 
 * */