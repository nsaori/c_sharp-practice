//p.174 sleep clear .SetCursorPosition(5, 1);

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loop
{
    class StringProcess2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clear");
            Thread.Sleep(1 * 1000);

            Console.Clear();

            Thread.Sleep(1 * 1000);

            Console.SetCursorPosition(5, 1);

            Console.WriteLine("Clear");
            Console.WriteLine();
            

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
