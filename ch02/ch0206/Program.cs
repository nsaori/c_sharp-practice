using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0206
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("인치? ");
            string sinch = Console.ReadLine();
            int inch = int.Parse(sinch);
            double cm = inch * 2.54;
            Console.WriteLine(sinch + " inch" + " = " + cm + " cm");
        }
    }
}
