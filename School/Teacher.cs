//20161021 saori
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Teacher
    {
        public string Name { get; set; }
        int age;
        public int Age
        {
            get { return age; }
            set { CheackAge(value); }
        }
        private void CheackAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("정확한 나이를 입력하주새요.");
            }
        }
        public string Subj { get; set; }

        public Teacher() {
            Name = "누구시죠";
            Age = 100;
            Subj = "뭘까";
        }
        public Teacher(string name, int age, string stuj)
        {
            Name = name;
            Age = age;
            Subj = stuj;
        }
        public Teacher(string name, string stuj)
        {
            Name = name;
            Age = 100;
            Subj = stuj;
        }
        public Teacher(string name)
        {
            Name = name;
            Age = 100;
            Subj = "뭘까";
        }

        public void printAll()  //이름,나이,전공 출력
        {
            Console.WriteLine("이름:{0}\t나이:{1}\t전공:{2}", Name, Age, Subj);
        }
    }
}
