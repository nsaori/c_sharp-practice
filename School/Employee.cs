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

        public Employee(){
            Name = "???";
            Age = 100;
            Dept = '_';
        }
        public Employee(string name, int age, char dept) {
            Name = name;
            Age = age;
            Dept = dept;
        }
        public Employee(string name, char dept) {
            Name = name;
            Age = 100;
            Dept = dept;
        }
        public Employee(string name) {
            Name = name;
            Age = 100;
            Dept = '_';
        }

        public void printAll()  //이름,나이,부서 출력
        {
            Console.WriteLine("이름:{0}\t나이:{1}\t부서:{2}", Name, Age, Dept);
        }
    }
}
