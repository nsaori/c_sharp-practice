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

        private int age;
        public int Age
        {
            get { return age; }
            set { CheckAge(value); }
        } 
        private void CheckAge(int age)
        {
            if (age > 0)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("정확한 나이(1~99)를 입력하세요.");
                Environment.Exit(0);
            }
        }

        public string Subj { get; set; }

        public Teacher(string name, int age, string subj)
        {
            Name = name;
            Age = age;
            Subj = subj;
        }
        public Teacher(string name, string subj)
        {
            Name = name;
            Age = 99;
            Subj = subj;
        }
        public Teacher(string name)
        {
            Name = name;
            Age = 99;
            Subj = "무전공";
        }
        public Teacher()
        {
            Name = "아무개";
            Age = 99;
            Subj = "무전공";
        }

        public void PrintAll()
        {
            Console.WriteLine(Name + "\t" + Age + "\t" + Subj);
        }
    }
}
