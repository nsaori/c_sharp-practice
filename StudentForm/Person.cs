// abstract class
//private,최소 public

//check age 생략

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age) {
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
            Name ="아무개";
            Age = 99;
        }
        public override string ToString() {
            return Name + "\t" + Age; 
        }
    }
}
