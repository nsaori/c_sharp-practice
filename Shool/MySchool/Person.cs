//20161024 inheritance상속 추가
//상속할 떈 private 아니라 protected~~

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    abstract class Person//: Object  최상의 클래스~~ 굳히 코딩안한다~~
    {
        public string Name { get; set; }
        int age;
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

        public Person(string name, int age) //:base()     //all
        {
            Name = name;
            Age = age;
        }
        public Person(string name) //:base()  //필수항
        {
            Name = name;
            Age = 100;
        }
        public Person() //:base() //default
        {
            Name = "아무게";
            Age = 100;
        }

        public virtual void PrintAll()  //이름,나이,학번 출력
        {
            Console.Write("이름:{0}\t나이:{1}\t", Name, age);
        }
    }
}
