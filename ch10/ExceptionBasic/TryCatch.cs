//p.451
//try catch finally
//예외발생시에도 정상실행되도록 한다.

//try catch catch catch...
//          (여러 경우를 고려해서 함)
//상속관계가 되면 제일 위가 하위 클래스,밑이 상위 클래스
//상속관계가 아니라면 순서무관

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionBasic
{
    class TryCatch
    {
        static void Main(string[] args)
        {
            string[] array = { "가", "나" };
            Console.Write("입력: ");
            string sinput = Console.ReadLine();
            try
            {
                int index = int.Parse(sinput);
                Console.Write("입력 숫자: " + index);
            }
            catch(FormatException e)    //상속관계가 되면 제일 위가 하위 클래스
            //catch(SystemException e)
            //catch(Exception e)
            {
                Console.WriteLine(e.GetType() + ": " + e.Message);
                /*
                Console.WriteLine("[ FormartException 예외발생 ]");
                Console.WriteLine("["+e.GetType()+"]");
                Console.WriteLine("[" + e.Message + "]");
                Console.WriteLine("[" + e.ToString() + "]");
                */
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.GetType() + ": " + e.Message);
            }
            catch (Exception e)   //상속관계가 되면 제일 밑이 상위 클래스
            {
                Console.WriteLine(e.GetType() + ": " + e.Message);
            }

            Console.WriteLine("[ 여기는 반드시 출력하고 싶다.]");
            
        }
    }
}
