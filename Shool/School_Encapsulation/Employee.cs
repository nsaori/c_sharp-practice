using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Employee
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

        public char Dept { get; set; }

        public Employee(string name, int age, char dept)
        {
            Name = name;
            Age = age;
            Dept = dept;
        }
        public Employee(string name, char dept)
        {
            Name = name;
            Age = 99;
            Dept = dept;
        }
        public Employee(string name)
        {
            Name = name;
            Age = 99;
            Dept = 'U';
        }
        public Employee()
        {
            Name = "아무개";
            Age = 99;
            Dept = 'U';
        }

        public void PrintAll()
        {
            Console.WriteLine(Name + "\t" + Age + "\t" + Dept);
        }
    }
}
