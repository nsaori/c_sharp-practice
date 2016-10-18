using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch0406
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int max = int.MaxValue, min = int.MinValue;

            Console.Write("숫자를 입력해주세요: ");
            a[0] = int.Parse(Console.ReadLine());
            max = min = a[0];

            for (int i = 0; i < a.Length; i++)  //input
            {
                Console.Write("숫자를 입력해주세요: ");
                a[i] = int.Parse(Console.ReadLine());
                if (max < a[i]) {
                    max = a[i];
                }
                if (min > a[i]) {
                    min = a[i];
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("가장 큰 수  : " + max);
            Console.WriteLine("가장 작은 수: " + min);
            Console.WriteLine();
        }
    }
}
