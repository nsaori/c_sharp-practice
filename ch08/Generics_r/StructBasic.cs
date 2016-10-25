//p.388 struct, 구조체
//생성자 - 변수초기화를 다 해야된다. 매개변수는 무관
//class vs structur
//-> reference? data?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    struct Point {
        public int x;
        public int y;
        public string testA;
        public string testB; // = "초기값";  //안된다.


        public Point(int x, int y) {
            this.x = x;
            this.y = y;
            this.testA = null;
            this.testB = null;
        }
        public Point(int xy)
        {
            this.x = xy;
            this.y = xy;
            this.testA = null;
            this.testB = null;
        }
        public Point(int x, int y,string test)
        {
            this.x = x;
            this.y = y;
            this.testA = test;
            this.testB = test;
        }
        /*
        public Point(int y) //overloading error 매개변수가 같다--
        {
            this.x = 0;
            this.y = y;
        }
        */
    }
    class StructBasic { 

        static void Main(string[] args)
        {
            //Point p ;  //생선자를 통해서 하는게 아니기땜에 값을 줘야 된다.
            Point p = new Point();
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);
            Console.WriteLine("[" + p.testA + "]");
            Console.WriteLine("[" + p.testB + "]");
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

            Point p1 = new Point(100, 200,"홍길동");
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine("[" + p1.testA + "]");
            Console.WriteLine("[" + p1.testB + "]");
        }
    }
}
