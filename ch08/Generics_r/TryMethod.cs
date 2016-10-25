// out p.387
//out .... -> return 하는것~~

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TryMethod
    {
        static void NextPositon(int x , int y, int vx, int vy, out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;

        }
        static void Main(string[] args)
        {

            int x = 0, y = 0;
            int vx = 1, vy = 1;
            Console.WriteLine("현재좌표: (" +x+ "," +y+ ")");
            NextPositon(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음좌표: (" + x + "," + y + ")");
            NextPositon(x, y, vx, vy, out x, out y);
            Console.WriteLine("다음좌표: (" + x + "," + y + ")");
            /*
            Console.Write("수자 입력: ");
            
            int su = int.Parse(Console.ReadLine());
            Console.WriteLine("입력한 숫자: " + su);
           
            int output;
            bool result = int.TryParse(Console.ReadLine(),out output);

            if (result)
            {
                Console.WriteLine("입력한 숫자: " + output);
            }
            else {
                Console.WriteLine("숫자를 입력하세요.");
            }
            */

        }
    }
}
