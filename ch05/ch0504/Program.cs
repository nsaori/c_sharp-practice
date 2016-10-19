//ch0504 p247
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0504
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 1000);
            //Console.WriteLine(a);
            while (true) {
                Console.Write("숫자를 입력해주세요: ");
                int ans = int.Parse(Console.ReadLine());
                if (ans == a)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
                else if (ans > a)
                {
                    Console.WriteLine(ans + "보다는 작은 숫자입나다.");
                }
                else {
                    Console.WriteLine(ans + "보다는 큰 숫자입니다.");
                }
                Console.WriteLine();
            }
        }
    }
}
