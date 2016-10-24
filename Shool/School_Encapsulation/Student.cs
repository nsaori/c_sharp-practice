using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student
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

        public int Stuid { get; set; }

        public Student(string name, int age, int stuid)
        {
            Name = name;
            Age = age;
            Stuid = stuid;
        }
        public Student(string name, int stuid)
        {
            Name = name;
            Age = 99;
            Stuid = stuid;
        }
        public Student(string name)
        {
            Name = name;
            Age = 99;
            Stuid = 201699;
        }
        public Student()
        {
            Name = "아무개";
            Age = 99;
            Stuid = 201699;
        }

        public void PrintAll()
        {
            Console.WriteLine(Name + "\t" + Age + "\t" + Stuid);
        }
    }
}
