using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    class Student :Person
    {
        public int Stuid { get; set; }

        public Student(string name, int age, int stid)  : base(name,age)
        {
            Stuid = stid;
        }
        public Student(string name) : base(name)
        {
            Stuid = 101699;
        }
        public Student() : base()
        {
            Stuid = 101699;
        }
        public override string ToString()
        {
            return base.ToString() + "\t" + Stuid;
        }
    }
}
