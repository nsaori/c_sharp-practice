//ch00504 p247
//삼암연산을 사용 < id else if...
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
            int a = rnd.Next(1000);
            Console.WriteLine(a);

            int ans;
            //방법 2
            do
            {
                Console.Write("숫자를 입력해주세요: ");
                ans = int.Parse(Console.ReadLine());
                //Console.WriteLine(ans == a ? "정답입니다!" : (ans < a ? ans + "보다 큰 숫자입니다." : ans + "보다 작은 숫자입니다")); //삼암연산은 break를 못쓴다.
                Console.Write(ans == a ? "정답" : (ans < a ? ans + "보다 큰 숫자" : ans + "보다 작은 숫자"));
                Console.WriteLine("입니다.");
                Console.WriteLine();

            } while (a!=ans);//삼안연산을 사용했기 떔에 여기서도 cheak!

            /*방법 1.
            while (true) {
                Console.Write("숫자를 입력해주세요: ");
                int ans = int.Parse(Console.ReadLine());

                Console.WriteLine(ans == a ? "정답입니다!" : (ans < a ? ans + "보다 큰 숫자입니다." : ans + "보다 작은 숫자입니다"));
               
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
            */
        }
    }
}
