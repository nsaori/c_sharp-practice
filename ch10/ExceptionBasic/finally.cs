//errer 처리 p.451
//finally


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasic
{
    class Finally
    {
        static void Main(string[] args)
        {
            try
            {
                //1. 정상
                //Console.WriteLine("[ 정상 ]");

                //2.예외
                //int n = 0;
                // int r = 10 / n;
                int n = int.Parse("일이삼");

                //3.return
                //return; 

                //4.Exit  ; 이것만은 finally 안된다.
                //Environment.Exit(0);

                Console.WriteLine("[ try ]");
            }
            catch(Exception e) {
                Console.WriteLine(e.GetType() + ": " +e.Message);
            }
            finally //4.exit제외하고 여기는 다 실행이 된다.
            {
                //
                Console.WriteLine("[ finally ]");
            }
            Console.WriteLine("[ 여기는 반드시 출력하고 싶다.]");
            
        }
    }
}
