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
        public string NAme { get; set; }
        private string name;
        int age;
        int stuid;

        public Student() {

        }
        public Student(string name, int age, int stuid) {
            this.name = name;
            this.age = age;
            this.stuid = stuid;
        }
        public Student(string name, int stuid)
        {
            this.name = name;
            this.stuid = stuid;
        }
        public Student(string name)
        {
            this.name = name;
        }

        public void printAll()  //이름,나이,학번 출력
        {
            Console.WriteLine("이름:{0}\t나이:{1}\t학번:{2}", name, age, stuid);
        }

        public int Age { 
            get{ return age; }
            set{ CheackAge(value); }
        }
        private void CheackAge(int age) {
            if (age > 0)
            {
                this.age = age;
            }
            else {
                Console.WriteLine("정확한 나이를 입력하주새요.");
            }
        }
    }
}
