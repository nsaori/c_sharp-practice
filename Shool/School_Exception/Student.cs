using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        public int Stuid { get; set; }

        public Student(string name, int age, int stuid) : base(name, age)
        {
            Stuid = stuid;
        }
        public Student(string name, int stuid) : base(name)
        {
            Stuid = stuid;
        }
        public Student(string name) : base(name)
        {
            Stuid = 201699;
        }
        public Student() //: base()
        {
            Stuid = 201699;
        }

        //public override void PrintAll()
        //{
        //    base.PrintAll();
        //    Console.WriteLine(Stuid);
        //}
        public override string ToString()
        {
            return base.ToString() + " " + Stuid;
        }
    }
}
