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
            Student s1 = new Student("홍길동", 20, 201601);
            s1.PrintAll();
            Student s2 = new Student("홍길순", 201602);
            s2.PrintAll();
            Student s3 = new Student("나맹구");
            s3.PrintAll();
            Student s4 = new Student();
            s4.PrintAll();
            Console.WriteLine();

            Teacher t1 = new Teacher("일강사", 30, "C#");
            t1.PrintAll();
            Teacher t2 = new Teacher("이강사", "C++");
            t2.PrintAll();
            Teacher t3 = new Teacher("삼강사");
            t3.PrintAll();
            Teacher t4 = new Teacher();
            t4.PrintAll();
            Console.WriteLine();

            Employee e1 = new Employee("일직원", 25, 'A');
            e1.PrintAll();
            Employee e2 = new Employee("이직원", 'B');
            e2.PrintAll();
            Employee e3 = new Employee("삼직원");
            e3.PrintAll();
            Employee e4 = new Employee();
            e4.PrintAll();
        }
    }
}
