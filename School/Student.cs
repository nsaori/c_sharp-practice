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

        public Student() //: base()
        {
            //Name = "아무게";
            //Age = 100;
            Stuid = 10001;
        }
        public Student(string name, int age, int stuid) : base(name,age)
        {
            Stuid = stuid;
        }
        public Student(string name, int stuid) : base(name)
        {
            Stuid = stuid;
        }
        public Student(string name) : base(name)  //필수항
        {
            Stuid = 10001;
        }

        public void printAll()  //이름,나이,학번 출력
        {
            Console.WriteLine("이름:{0}\t나이:{1}\t학번:{2}", Name, Age, Stuid);
        }
    }
}
