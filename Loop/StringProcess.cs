//p.169~ 문자열  처리 method -.split(), .trim(), join()

 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class StringProcess
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clear");
            Console.Clear();
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Clear");
            Console.WriteLine();
            //.join()
            string[] sa3 = { "AA", "BB", "cc", "DD", "EE" };
            //배열의 요소를 다 공백을 주고 붙어서 출력하고 싶은 떄~~
            /*
            Console.Write("[");
            for (int i = 0; i < sa3.Length; i++)
            {
                Console.Write(sa3[i]);
                if (i != sa3.Length - 1) {
                    Console.Write(" ");
                }
            }
            Console.WriteLine("]");
            */
            //Console.WriteLine(sa3.Join);
            Console.WriteLine(string.Join(("="), sa3));
            Console.WriteLine();

            //.trim()
            string t = "   test   \n";
            Console.WriteLine("[" + t + "]");
            Console.WriteLine("[" + t.TrimStart() + "]");   //앞쪽 공백 짜르기
            Console.WriteLine("[" + t.TrimEnd() + "]");     //뒤쪽 짜르기
            Console.WriteLine("[" + t.Trim() + "]");        //양쪽 짜르기
            Console.WriteLine();

            int ii = int.Parse("    111     ");
            Console.WriteLine("ii= " + ii);
            Console.WriteLine("111      ".Length);
            string tt = "111        ".Trim();
            Console.WriteLine(tt.Length);      
            Console.WriteLine();


            //.solit()
            string s = "Potato-=-, Tomato,-=-, Aa, Bb, Cc";
            Console.WriteLine(s);
            Console.WriteLine(s.ToUpper()); //글자 자체가 바뀌는건 아니다. 원본은 그대로!
            Console.WriteLine(s.ToLower());
            Console.WriteLine(s);
            s = s.ToUpper(); // 원본을 바꾸려면...
            Console.WriteLine(s);
            Console.WriteLine();

            string[] sa = s.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries); 
            //Console.WriteLine("sa.Length" + sa.Length);
            int index = 0;
            foreach (string token in sa)
            {
                Console.WriteLine("sa["+index+"] = " + token);
                index++;
            }
            Console.WriteLine();

            string[] sa1 = s.Split(new string[] { "-=-" }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("sa.Length" + sa.Length);
            int j = 0;
            foreach (string token in sa1)
            {
                Console.WriteLine("sa[" + j + "] = " + token);
                j++;
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
