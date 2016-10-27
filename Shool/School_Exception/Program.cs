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
            IManagement m = new ManagementList();

            try
            {
                m.Add(new Student("홍길동", 20, 201601));
            }
            catch (InvaildAgeException e)
            {
                Console.WriteLine("나이예외: "+e.Message);
            }
            catch (DuplicatedException e)
            {
                Console.WriteLine("중복예외: " + e.Message);
            }
            
            try
            {
                m.Add(new Teacher("일강사", 30, "C#"));
            }
            catch (InvaildAgeException e)
            {
                Console.WriteLine("나이예외: " + e.Message);
            }
            catch (DuplicatedException e)
            {
                Console.WriteLine("중복예외: " + e.Message);
            }

            try
            {
                m.Add(new Employee("일직원", 25, 'A'));
            }
            catch (InvaildAgeException e)
            {
                Console.WriteLine("나이예외: " + e.Message);
            }
            catch (DuplicatedException e)
            {
                Console.WriteLine("중복예외: " + e.Message);
            }

            m.PrintAll();
            Console.WriteLine();

            try
            {
                Person p = m.Search("일강사");
                /*if(p!=null)*/ p.PrintAll();
            }
            catch (NotFoundException e)
            {
                Console.WriteLine("이름예외: " + e.Message);
            }
            Console.WriteLine();

            try
            {
                Person s = new Student("일강사", 22, 201401);
                m.Update(s);
                m.PrintAll();
            }
            catch (InvaildAgeException e)
            {
                Console.WriteLine("나이예외: " + e.Message);
            }
            catch (NotFoundException e)
            {
                Console.WriteLine("수정예외: " + e.Message);
            }
            Console.WriteLine();

            try
            {
                m.Remove("일강사");
                m.PrintAll();
            }
            catch (NotFoundException e)
            {
                Console.WriteLine("삭제예외: " + e.Message);
            }
            Console.WriteLine();

            List<Person> data = m.ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }


            //1.Definition
            /*
            Person p = new Student("홍길동",20,201601);
            p.Name = "사오정"; //ok
            //p.Stuid = 201677;//err
            p.ToString();      //override?
            */

            //2.Array
            /*
            Person[] pa = new Person[3];
            pa[0] = new Student("홍길동", 20, 201601);
            pa[1] = new Teacher("일강사", 30, "C#");
            pa[2] = new Employee("일직원", 25, 'A');
            for (int i = 0; i < pa.Length; i++)
            {
                pa[i].PrintAll();
            }
            foreach (var item in pa)
            {
                item.PrintAll();
            }
            */

            //3.Parameter
            /*
            public void Add(Person p)
            {

            }            
            Add(new Student("홍길동", 20, 201601));
            */

            //4.Return
            /*
            public Person search(string name)
            {
                //...
                return new Student("홍길동", 20, 201601);
            } 
            */

            //5.Override
            /*
            Person p = new Student("홍길동", 20, 201601);
            p.PrintAll(); //new      홍길동  20
                          //override 홍길동  20  201601
            Console.WriteLine(p);           //x School.Student
            Console.WriteLine(p.ToString());//o 홍길동(20) 201601
            */


            /*
            Person p = new Student("홍길동", 20, 201601);
            p.PrintAll();
            p = new Student("홍길순", 201602);
            p.PrintAll();
            p = new Student("나맹구");
            p.PrintAll();
            p = new Student();
            p.PrintAll();
            Console.WriteLine();

            p = new Teacher("일강사", 30, "C#");
            p.PrintAll();
            p = new Teacher("이강사", "C++");
            p.PrintAll();
            p = new Teacher("삼강사");
            p.PrintAll();
            p = new Teacher();
            p.PrintAll();
            Console.WriteLine();

            p = new Employee("일직원", 25, 'A');
            p.PrintAll();
            p = new Employee("이직원", 'B');
            p.PrintAll();
            p = new Employee("삼직원");
            p.PrintAll();
            p = new Employee();
            p.PrintAll();
            */
        }
    }
}
