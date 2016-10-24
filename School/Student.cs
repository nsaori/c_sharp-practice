//20161021 saori
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

        public Student() {
            Name = "아무게";
            Age = 100;
            Stuid = 10001;
        }
        public Student(string name, int age, int stuid) {
            Name = name;
            Age = age;
            Stuid = stuid;
        }
        public Student(string name, int stuid)
        {
            Name = name;
            Age = 100;
            Stuid = stuid;
        }
        public Student(string name)   //필수항
        {
            Name = name;
            Age = 100;
            Stuid = 10001;
        }

        public void printAll()  //이름,나이,학번 출력
        {
            Console.WriteLine("이름:{0}\t나이:{1}\t학번:{2}", Name, Age, Stuid);
        }
    }
}
