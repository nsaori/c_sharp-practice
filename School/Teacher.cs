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
        string name;
        int age;
        string stuj;

        public Teacher() {

        }
        public Teacher(string name, int age, string stuj)
        {
            this.name = name;
            this.age = age;
            this.stuj = stuj;
        }
        public Teacher(string name, string stuj)
        {
            this.name = name;
            this.stuj = stuj;
        }
        public Teacher(string name)
        {
            this.name = name;
        }

        public void printAll()  //이름,나이,전공 출력
        {
            Console.WriteLine("이름:{0}\t나이:{1}\t전공:{2}", name, age, stuj);
        }
    }
}
