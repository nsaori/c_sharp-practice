using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    class boolBacis
    {
        static void Main(string[] args) {
            int[] a = { 11, 22, 33, 44, 55, 66 };
            Console.WriteLine(true);    //True
            //Console.WriteLine(TRUE);
            //Console.WriteLine(True);
            Console.WriteLine(false);   //False
            //Console.WriteLine(FALSE);
            //Console.WriteLine(False);

            Console.WriteLine();
            Console.WriteLine(10 >= 52);
            Console.WriteLine(10 <= 52);
            Console.WriteLine(10 != 10);
            Console.WriteLine(1 ==1);

            Console.WriteLine();
            Console.WriteLine(int.Parse("123"));
            Console.WriteLine(float.Parse("123.455"));
            Console.WriteLine(long.Parse("123").GetType());
            Console.WriteLine(double.Parse("234.568").GetType()+" ");
            Console.WriteLine();

            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Hour < 3 || 8< DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
            Console.WriteLine(15 <= DateTime.Now.Hour && DateTime.Now.Hour <= 16);



            Console.WriteLine();
            foreach (int item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
    }
}

//ctrl K C -> 주석처리
// 한줄삭제 ; shift delete