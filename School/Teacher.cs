//20161021 saori
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
        
        public Teacher(string name, int age, string stuj):base(name,age)
        {
            Subj = stuj;
        }
        public Teacher(string name, string stuj):base(name)
        {
            Subj = stuj;
        }
        public Teacher(string name):base(name)
        {
            Subj = "뭘까";
        }
        public Teacher()
        {
            Subj = "뭘까";
        }

        public void PrintAll()  //이름,나이,전공 출력
        {
            base.PrintAll();
            Console.WriteLine("전공:{0}",Subj);
        }
    }
}
