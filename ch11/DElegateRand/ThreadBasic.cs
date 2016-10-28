//p.495 Thread

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DElegateRand
{
    class ThreadBasic { 
        static void Main(string[] args)
        {
            Console.WriteLine("Main() start");

            //Thread t1 = new Thread(TestMethod);
            //t1.Start();
            new Thread(TestMethod).Start();
            //Thread.Sleep(1);

            //Thread t2 = new Thread(delegate() {
            new Thread(delegate () {
                for (int i = 0; i < 100; i++) { Console.Write("B"); }
            }).Start();
            //t2.Start();

            //Thread t3 = new Thread(() => {
            new Thread(() => {
                for (int i = 0; i < 100; i++) { Console.Write("C");  }
            }).Start();
            //t3.Start();

            Console.WriteLine("Main() end");
        }

        private static void TestMethod()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write("A");
            }
        }
    }
}
