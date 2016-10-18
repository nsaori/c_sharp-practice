using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class While
    {
        static void Main(string[] args)
        {
            int i =1;
            while(i <= 5){
                Console.WriteLine("출력" + i);
                i++;
            }
            Console.WriteLine(i);
        }
    }
}
