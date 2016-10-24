//20161021 saori
//생성자constructor ;초기화하기 위한 거! for init
//다형성, 부모은 자식 매소드 호출 불가

//다형성 할 떄 알아야 할 게 5가지
// 1.definition, 2.array,3.parameter,4.return,5.overwriting
//overloading에 정확한게 없으면 부모가 호출된다

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Definiton
            /*
            Person p = new Student("홍길동", 20, 2001601);
            p.Name = "시오정";
            //p.Stuid = 201677
            p.PrintAll();
            */

            //2.Array
            /*
            Person[] pa = new Person[3];
            pa[0] = new Student("홍길동", 20, 2001601);
            pa[1] = new Teacher("일강사", 30, "C#");
            pa[2] = new Employee("홍길동", 20, 'A');
            /*
            for (int i = 0; i < pa.Length; i++)
            {
                pa[i].PrintAll();
            }*/
            /*
            foreach (Person item in pa)
            {
                item.PrintAll();
            }
            */

            //3.Polymorphic Parameter
            /*
            public void Add(Person p) {
                ...
             }
             Add(new Student());

            */

            // 4.return
            /*
            public Person search(string name)
            {
                ...
                return new Student("홍길동", 20, 2001601);
            }
            */

            //5.overwriting
            Person p = new Student("홍길동", 20, 2001601);
            p.PrintAll();  //new 홍길동  20
                           //override 홍길동 20 2001601  -> 자식 class method 호출된다

            /*
            Person p = new Person();
            p = new Student("홍길순", 2010);
            p = new Student("혼길태");
            p = new Student();
            p.PrintAll();
            p.PrintAll();
            p.PrintAll();
            p.PrintAll();
            Console.WriteLine();

            //Teacher객체 4개 생성하고 값출력
            p = new Teacher("교수", 50, "컴퓨터공학과");
            p = new Teacher("강사님", "정보통신학과");
            p = new Teacher("선생님");
            p = new Teacher();
            p.PrintAll();
            p.PrintAll();
            p.PrintAll();
            p.PrintAll();
            Console.WriteLine();
            //Employee객체 4개 생성하고 값출력
            Employee e1 = new Employee("아아아", 30, 'a');
            Employee e2 = new Employee("호호호", 'ㅎ');
            Employee e3 = new Employee("캬캬캬");
            Employee e4 = new Employee();
            e1.PrintAll();
            e2.PrintAll();
            e3.PrintAll();
            e4.PrintAll();
            Console.WriteLine();
            */

            //Student객체 4개 생성하고 값출력
            /* Student s1 = new Student("홍길동", 27, 2012);
             Student s2 = new Student("홍길순", 2010);
             Student s3 = new Student("혼길태");
             Student s4 = new Student();
             s1.PrintAll();
             s2.PrintAll();
             s3.PrintAll();
             s4.PrintAll();
             Console.WriteLine();
             //Teacher객체 4개 생성하고 값출력
             Teacher t1 = new Teacher("교수", 50, "컴퓨터공학과");
             Teacher t2 = new Teacher("강사님","정보통신학과");
             Teacher t3 = new Teacher("선생님");
             Teacher t4 = new Teacher();
             t1.PrintAll();
             t2.PrintAll();
             t3.PrintAll();
             t4.PrintAll();
             Console.WriteLine();
             //Employee객체 4개 생성하고 값출력
             Employee e1 = new Employee("아아아", 30, 'a');
             Employee e2 = new Employee("호호호", 'ㅎ');
             Employee e3 = new Employee("캬캬캬");
             Employee e4 = new Employee();
             e1.PrintAll();
             e2.PrintAll();
             e3.PrintAll();
             e4.PrintAll();
             Console.WriteLine();
             */
        }
    }
}

