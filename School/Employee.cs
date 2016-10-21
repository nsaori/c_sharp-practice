//20161021 saori
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Employee
    {
        string name;
        int age;
        char dept;

        public Employee(){

        }
        public Employee(string name, int age, char dept) {
            this.name = name;
            this.age = age;
            this.dept = dept;
        }
        public Employee(string name, char dept) {
            this.name = name;
            this.dept = dept;
        }
        public Employee(string name) {
            this.name = name;
        }

        public void printAll()  //이름,나이,부서 출력
        {
            Console.WriteLine("이름:{0}\t나이:{1}\t부서:{2}", name, age, dept);
        }
    }
}
