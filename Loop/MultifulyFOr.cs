//p163

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class MultiplyFOr
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하시오(1-20): ");
            int max = int.Parse(Console.ReadLine());
            //int sum = 0;   //곱할 땐 1부터! 
            long sum = 1;   //곱은 크니까 overflow 주의한다.
            //double sum = 1;  //long 보다 크다. 
            

            for (int i = 1; i <= max; i++)  //i는 1부터!
            {
                sum *= i;
            }
            Console.WriteLine(" 1 ~ {0} 의 곱: {1}", max, sum);
            
        }
    }
}


/*
 * 미래엔 alfa go가 코딩하겠지(강사님)
 * 
 * */