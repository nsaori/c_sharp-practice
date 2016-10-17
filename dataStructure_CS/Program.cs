//saori20161017 circled queue
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        int N = 5;
        int[] Q = new int[N];
        int head = 0, tail = 0;
        
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.삽입\n2.삭제\n3.printout\n4.the end\n");
            Console.Write("숫자를 입력하시요: ");
            choice = Console.Read();

            switch (choice) {
                case 1:
                    enqueue();
                    break;
                case 2:
                    dequeue();
                    break;
                case 3:
                    printData();
                    break;
                case 4:
                    Console.WriteLine("the end");
                    //exit(0);
                    break;
                default:
                    Console.WriteLine("숫자1~4를 입력해주세요.");
                    break;

            }
        }
        int enqueue(){
            if ((tail+ 1) % N == head) {
                Console.WriteLine("errer; overflow.");
                return 0;
            }
            Console.Write("삽입할 숫자를 입력하세요: ");

            tail = (tail + 1) % N;
            Q[tail] = Console.read();
            return 1;
        }
        int dequeue() {
            if (head == tail) {
                Console.WriteLine("errer; underflow.");
                return 0;
            }
            head = (head + 1) % N;
            Q[head] = 0;
            return 1;
        }
        int printData() {
            if (head == tail)
            {
                Console.WriteLine("errer; underflow.");
                return 0;
            }
            foreach(int x in Q) {

            }
        }

    }
}
