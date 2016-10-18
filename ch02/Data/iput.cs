using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class iput
    {
        static void Main(string[] args) {
            /*
            string input = Console.ReadLine();  //문자열 입력하기
            Console.WriteLine(input);
            Console.WriteLine(input + 45);  //문자 + -> 붙이기 연산
            //int number = input + 45;
            int number = int.Parse(input)+12 ;
            Console.WriteLine(number);
            */
              
            Console.Write("name? ");
            string name = Console.ReadLine();
            Console.Write("age? ");
            string sage = Console.ReadLine();
            int age = int.Parse(sage);
            Console.Write("파이? ");
            string spi = Console.ReadLine();
            double pi = double.Parse(spi);
            Console.WriteLine("이름: " + name + "\t나이: " + age + "\tPI: " + pi);

        }
    }
}
