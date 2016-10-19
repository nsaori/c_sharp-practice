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

            for (int i = 1; i < a.Length; i++)  //input
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
            Console.WriteLine("가장 큰 수  : " + max);     // Console.WriteLine("max={0.2:d}",m); 
            Console.WriteLine("가장 작은 수: " + min);   // Console.WriteLine("min={0.2:d}",min);
            Console.WriteLine(); 

            Console.WriteLine("max={0,2:d}", max);   //"{몇번쨰,자릿수:type}",
            Console.WriteLine("min={0,2:d}", min);
            Console.WriteLine("max={0,2:d} min={1,2:d} max={0,2:d} min={1,2:d} a[1]={2,2:d} ", max, min, a[1]);
            Console.WriteLine();

            foreach (int n in a)
            {
                Console.Write("{0 }", n);
            }
            Console.WriteLine();
            foreach (int n in a)
            {
                Console.Write("{0,5:D}", n);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("a.Length: " + a.Length);
            Console.WriteLine("a.GetLength(0): " + a.GetLength(0));
            Console.WriteLine("a.Rank: " + a.Rank);
            Console.WriteLine();
        }
    }
}
