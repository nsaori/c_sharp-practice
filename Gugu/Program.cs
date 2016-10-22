using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gugu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("단? ");
            int input = int.Parse(Console.ReadLine());
            Gugudan g = new Gugudan(input);
            //출력
            g.PrintAll();
        }
    }
}
