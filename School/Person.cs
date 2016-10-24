//20161024 inheritance상속 추가

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Person
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

        public Person(string name, int age)     //all
        {
            Name = name;
            Age = age;
        }
        public Person(string name)   //필수항
        {
            Name = name;
            Age = 100;
        }
        public Person()  //default
        {
            Name = "아무게";
            Age = 100;
        }

        public void PrintAll()  //이름,나이,학번 출력
        {
            Console.Write("이름:{0}\t나이:{1}\t", Name, age);
        }
    }
}
