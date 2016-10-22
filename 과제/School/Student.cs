//20161021 saori
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
        //private string name;
        int age;
        //int stuid;
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
            Console.WriteLine("이름:{0}\t나이:{1}\t학번:{2}", Name, age, Stuid);
        }
    }
}
