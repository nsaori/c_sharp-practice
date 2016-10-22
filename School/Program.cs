//20161021 saori
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args) {
            //Student객체 4개 생성하고 값출력
            Student s1 = new Student("홍길동", 27, 2012);
            Student s2 = new Student("홍길순", 2010);
            Student s3 = new Student("혼길태");
            Student s4 = new Student();
            s1.printAll();
            s2.printAll();
            s3.printAll();
            s4.printAll();
            Console.WriteLine();
            //Teacher객체 4개 생성하고 값출력
            Teacher t1 = new Teacher("교수", 50, "컴퓨터공학과");
            Teacher t2 = new Teacher("강사님", "정보통신학과");
            Teacher t3 = new Teacher("선생님");
            Teacher t4 = new Teacher();
            t1.printAll();
            t2.printAll();
            t3.printAll();
            t4.printAll();
            Console.WriteLine();
            //Employee객체 4개 생성하고 값출력
            Employee e1 = new Employee("아아아", 30, 'a');
            Employee e2 = new Employee("호호호", 'ㅎ');
            Employee e3 = new Employee("캬캬캬");
            Employee e4 = new Employee();
            e1.printAll();
            e2.printAll();
            e3.printAll();
            e4.printAll();
            Console.WriteLine();
        }
    }
}
