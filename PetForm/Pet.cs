// abstract class
//private,최소 public

//check age 생략

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetForm
{
    abstract class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Pet(string name, int age) {
            Name = name;
            Age = age;
        }
        public Pet(string name)
        {
            Name = name;
            Age = 99;
        }
        public Pet()
        {
            Name ="아무개";
            Age = 99;
        }
        public override string ToString() {
            return Name + "\t" + Age; 
        }
    }
}
