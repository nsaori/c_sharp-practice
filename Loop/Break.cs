//p163

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Break
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10 ; i++)
            {
                if (i == 5)
                {
                    //break; //4까지출력된다
                    continue;  //5만 출력하지 않는다.
                }
                Console.WriteLine("i = " + i);
            }
        }
    }
}


/*
 * 
 * 
 * */  