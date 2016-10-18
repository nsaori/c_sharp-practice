using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class doWhile
    {
        static void Main(string[] args)
        {
            int i = 0;
            
            do
            {
                Console.WriteLine("출력" + i);
                i++;

            }while (i <= 5) ;
            Console.WriteLine(i);

            /*
            i = 0;
            while (i <= 5)
            {
                Console.WriteLine("출력" + i);
                i++;

            } 
            Console.WriteLine(i);
            */
        }
    }
}
/*while, dowhile -> 결과; 같았다.
 * while,do-while -> coding이 길어진다.
 * 조건문? 증가? 시작? 어디?
 * */