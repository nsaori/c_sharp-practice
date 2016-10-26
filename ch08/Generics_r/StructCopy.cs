//p.388 struct, 구조체
//생성자 - 변수초기화를 다 해야된다. 매개변수는 무관
//class vs structur
//-> reference? data?

//class ; copy by reference
//structure ; copy by data  //옛날에 class 이전에 사용했던 것/ 안되는것도 많다.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class PointClass
    {
        public int x;
        public int y;
        public string testA;
        public string testB; // = "초기값";  //안된다.


        public PointClass(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.testA = null;
            this.testB = null;
        }

    }
    struct PointStruct {
        public int x;
        public int y;
        public string testA;     
        public string testB; // = "초기값";  //안된다.


        public PointStruct(int x, int y) {
            this.x = x;
            this.y = y;
            this.testA = null;
            this.testB = null;
        }
        
    }
    class StructCopy { 

        static void Main(string[] args)
        {
            PointClass pcA = new PointClass(10,20);  //copy by reference
            PointClass pcB = pcA;           // = pointer
            pcB.x = 100;
            pcB.y = 200;
            Console.WriteLine("pcA: "+pcA.x +"," + pcA.y);
            Console.WriteLine("pcB: " + pcB.x + "," + pcB.y);
            Console.WriteLine();

            PointStruct psA = new PointStruct(10, 20);  //copy by data
            PointStruct psB = psA;
            psB.x = 100;
            psB.y = 200;
            Console.WriteLine("psA: " + psA.x + "," + psA.y);
            Console.WriteLine("psB: " + psB.x + "," + psB.y);
            Console.WriteLine();

            //pcA = psA; //type 안 맞아요~~
            //psB = pcB;
        }
    }
}
