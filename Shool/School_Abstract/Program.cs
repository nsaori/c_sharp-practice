﻿using System;
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
            Management m = new Management();
            m.Add( new Student("홍길동", 20, 201601) );
            m.Add( new Teacher("일강사", 30, "C#") );
            m.Add( new Employee("일직원", 25, 'A') );
            m.PrintAll();
            Console.WriteLine();

            Person p = m.search("일직원");
            if(p!=null) p.PrintAll();


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
