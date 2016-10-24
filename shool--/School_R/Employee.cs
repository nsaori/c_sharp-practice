using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Employee:Person
    {
        public char Dept { get; set; }

        public Employee(string name, int age, char dept):base(name,age)
        {
           
            Dept = dept;
        }
        public Employee(string name, char dept) : base(name)
        {
            
            Dept = dept;
        }
        public Employee(string name) : base(name)
        {
           
            Dept = 'K';
        }
        public Employee()
        {
           
            Dept = 'S';
        }

        public override void PrintAll()
        {
            base.PrintAll();
            Console.WriteLine(Dept);
        }
    }
}
