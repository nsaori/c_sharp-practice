//20131024 saori ch7 상속-inheritance
// Shadow(상속관계아님;이전)/ Hide (상속관계임;객체지향이후) p.341
//함수,함수집합: (객체지향 이전)function,library   / (객체지향 이후)method,api
//static, local변수
//부모;보통 protected 로

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Parent
    {
        public int variable = 273;
        public void Method()
        {
            Console.WriteLine("부모 method");
        }
    }
    class Child : Parent
    {
        public string variable = "홍길동";
        public void Method()
        {
            Console.WriteLine("자식 method");
        }
    }
    class ShadowHide
    {
        //satatic 변수
        public static int number = 10;  //정상적으로 static변수는 대문자로 쓴다지만~

        static void Main(string[] args)
        {
            //local 변수
            int number = 20;
            Console.WriteLine(number);  //20  showing(상속관계아님)
            Console.WriteLine(ShadowHide.number);   //10 showing 전꺼 
            Console.WriteLine();

            Child c = new Child();
            Console.WriteLine(c.variable);//홍길동 //273은 안 나온다; 부모variable hide됬다.(상속관계임)
            Console.WriteLine(((Parent)c).variable);  //hiding전
            //Parent p = (Parent)c;
            //Console.WriteLine(p.variable);
            Console.WriteLine();

            c.Method();  //hiding
            ((Parent)c).Method();
        }
    }
}


//개발자는 service기업이다. 고객이 원하면 해줘야 된다 > 안된다는 안된다~~