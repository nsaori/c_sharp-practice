using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class increment
    {
        static void Main(string[] args) {
            /*
            int number = 10;
            Console.WriteLine(number++); 
            Console.WriteLine(number);  //11
            number++;
            Console.WriteLine(number);  //12
            number--;
            Console.WriteLine(number); //11
            Console.WriteLine(number--); //11
            Console.WriteLine(--number); //9
            */
            int number = 10;
            Console.WriteLine(++number);
            Console.WriteLine(number);
            Console.WriteLine(--number);
            Console.WriteLine(number);
            Console.WriteLine();

            Console.WriteLine(number++);
            Console.WriteLine(number);
            Console.WriteLine(number--);
            Console.WriteLine(number);
        }
    }
}
