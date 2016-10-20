//ch5 class  p.197 List Class
//20161020
//reference 참조
//Math class ->객체 생산이 안된다.(static)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassUses
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);
            list.Add(64);
            Console.WriteLine();

            Console.WriteLine("Count: " + list.Count); //요소 개수
            foreach (var item in list)
            {
                Console.WriteLine("item: " + item);
            }

        }
    }
}
