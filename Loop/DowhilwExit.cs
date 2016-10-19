//p163

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class DOWhileExit
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.Write("입력(q:종료): ");
                input = Console.ReadLine();
            } while (input != "q");
            
        }
    }
}


/*
 * 
 * 
 * */