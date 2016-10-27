using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("숫자를 입력해주새요: ");
            string sinput = Console.ReadLine();

            for (int i = 0; i < sinput.Length; i++)
            {
                //if('0' > sinput[i] || sinput[i] > '9')
                if(!char.IsDigit(sinput[i]))
                {
                    Console.WriteLine("정확한 숫자를 입력해주세요.");
                    return;
                }
            }
            
            int input = int.Parse(sinput);
            //int input = int.Parse(Console.ReadLine());
            if (0<=input && input < array.Length)
            {
                Console.WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");
            }
            else
            {
                Console.WriteLine("인덱스 범위를 넘었습니다.");
            }
            
        }
    }
}
