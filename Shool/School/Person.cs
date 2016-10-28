using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    abstract class Person
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
            if (age > 0 && age < 120)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("정확한 나이(1~99)를 입력하세요.");
                Environment.Exit(0);
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(string name)
        {
            Name = name;
            Age = 99;
        }
        public Person()
        {
            Name = "아무개";
            Age = 99;
        }

        public void PrintAll()
        {
            //Console.Write(Name + "\t" + Age + "\t");

            //Console.WriteLine(ToString());//10
            //Console.WriteLine(this.ToString());//15
            Console.WriteLine(this);//4
        }
        public override string ToString()
        {
            return Name+"("+Age+")";
        }
    }
}
