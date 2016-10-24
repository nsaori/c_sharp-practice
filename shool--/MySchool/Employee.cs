//20161021 saori
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Employee : Person
    {
        public char Dept { get; set; }
        
        public Employee(string name, int age, char dept) : base(name,age)
        {
            Dept = dept;
        }
        public Employee(string name, char dept) : base(name)
        {
            Dept = dept;
        }
        public Employee(string name) : base(name)
        {
            Dept = '_';
        }
        public Employee():base()
        {
            Dept = '_';
        }
        public override void PrintAll()  //이름,나이,부서 출력
        {
            base.PrintAll();
            Console.WriteLine("부서:{0}", Dept);
        }
    }
}
