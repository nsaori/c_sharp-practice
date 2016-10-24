using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher : Person
    {
        public string Subj { get; set; }

        public Teacher(string name, int age, string subj) : base(name, age)
        {
            Subj = subj;
        }
        public Teacher(string name, string subj) : base(name)
        {
            Subj = subj;
        }
        public Teacher(string name) : base(name)
        {
            Subj = "무전공";
        }
        public Teacher()
        {
            Subj = "무전공";
        }

        //public override void PrintAll()
        //{
        //    base.PrintAll();
        //    Console.WriteLine(Subj);
        //}
        public override string ToString()
        {
            return base.ToString() + " " + Subj;
        }
    }
}
