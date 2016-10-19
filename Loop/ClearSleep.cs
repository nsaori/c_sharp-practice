//p.176 sleep clear .SetCursorPosition(5, 1);
//벌래가 움직힌다~~

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loop
{
    class ClearSleep
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 50) {
                Console.Clear();
                Console.SetCursorPosition(x, 3);

                if (x % 3 == 0) {
                    Console.WriteLine("___@");
                }
                else if (x%3 ==1)
                {
                    Console.WriteLine("_^@");
                }
                else
                {
                    Console.WriteLine("^_@");
                }
                Thread.Sleep(100);  //속도 변경은 여기서~!
                x++;
            }

        }
    }
}


/*
 *  string[] sa = s.Split(new char[] { ',' }); 
 *  string[] sa = s.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries); 
 *  StringSplitOptions.RemoveEmptyEntries //공백은 무시된다
 * 
 * .trim()  =앞뒤 공백 제거
 * * 가운대는 안됀다.
 * 
 * 
 * .jpon
 * string.Join(("사이에 붙이고싶은 것"), 배열
 * string.Join(("="), sa3
 * */
