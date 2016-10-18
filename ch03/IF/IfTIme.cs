using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF
{
    class IfTIme
    {
        static void Main(string[] args) {
            Console.Write(DateTime.Now.Year  +"년 ");
            Console.Write(DateTime.Now.Month + "월 " );
            Console.Write(DateTime.Now.Day + "일 ");
            Console.Write(DateTime.Now.Hour + "시 ");
            Console.Write(DateTime.Now.Minute + "분 ");
            Console.WriteLine(DateTime.Now.Second + "초 ");

            int hour = DateTime.Now.Hour;
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전 " + DateTime.Now.Hour + "시 입니다.");
            }
            else {
                Console.WriteLine("오후 " + DateTime.Now.Hour + "시 입니다.");
            }
        }
    }
}
