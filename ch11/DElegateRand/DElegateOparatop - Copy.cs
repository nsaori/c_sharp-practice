//p.491

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DElegateRand
{

    class DelegateOperator
    {
        public delegate void SendString(string message);

        static void Main(string[] args)
        {
            SendString sayHello, sayGoodbye, multiDelegate;

            sayHello = Hello;
            sayGoodbye = Goodbye;

            multiDelegate = sayHello;
            multiDelegate += sayGoodbye;
            multiDelegate("윤인성");

            Console.WriteLine();
            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("윤인성");

            Console.WriteLine();
            multiDelegate -= sayGoodbye;
            multiDelegate("윤인성");
        }

        private static void Hello(string message)
        {
            Console.WriteLine("Hello. " + message + "님...!");
        }

        private static void Goodbye(string message)
        {
            Console.WriteLine("Goodbye. " + message + "님...!");
        }
    }
}
