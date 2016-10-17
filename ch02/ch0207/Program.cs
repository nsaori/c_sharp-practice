using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0207
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kg? ");
            string skg = Console.ReadLine();
            int kg = int.Parse(skg);
            double pound = kg * 2.20462262;
            Console.WriteLine(skg + " kg" + " = " + pound + " pound");
        }
    }
}
