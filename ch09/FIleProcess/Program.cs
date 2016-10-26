//ch9 interface - file io p.424~
//지속성/연속성/consistance(파일에 기록 저장) file io -> networking ,원격chating,wed,등 응용이 도니다
// <-> 현재 시점의 정보들(기록저장 불필)

//StreamWriter,StreamReader ;  WriteAllText ,ReadAllText

using System;
using System.Collections.Generic;using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleProcess
{
    class Program
    {
        public static object FIle { get; private set; }

        static void Main(string[] args)
        {
            File.WriteAllText(@"C:\Users\517-11\Desktop\saori\c#\c_sharp-practice\ch09\FIleLoot\test.txt","문자열을 파일에 씁니다.");

            using (StreamWriter w = new StreamWriter(@"C:\Users\517-11\Desktop\saori\c#\c_sharp-practice\ch09\FIleLoot\test.txt")) {
                w.WriteLine("안녕하세요.");
                w.WriteLine("StreamWriter 클래스를 사용했습니다.");
                w.WriteLine("글자를 여러 줄 입력해봅니다.");
                for (int i = 0; i < 10; i++)
                {
                    w.WriteLine("반복문 - " + i);
                }
            }

            //파일에 입력한 내용을 표시한다.
            //Console.WriteLine(File.ReadAllText(@"C:\Users\517-11\Desktop\saori\c#\c_sharp-practice\ch09\FIleLoot\test.txt"));

            //한줄씩 읽어오기
            using(StreamReader r = new StreamReader(@"C:\Users\517-11\Desktop\saori\c#\c_sharp-practice\ch09\FIleLoot\test.txt"))
            {
                string line;
                while((line = r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}


/*
 * file io
 * database 
 */