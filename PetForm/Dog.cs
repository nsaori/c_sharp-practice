using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetForm
{
    class Dog :Pet
    {
        public string Breeds { get; set; }

        public Dog(string name, int age, string breeds)  : base(name,age)
        {
            Breeds = breeds;
        }
        public Dog(string name) : base(name)
        {
            Breeds = "뭐개";
        }
        public Dog() : base()
        {
            Breeds = "뭐개";
        }
        public override string ToString()
        {
            return "강아지" + "\t" + base.ToString() + "\t" + Breeds;
        }
    }
}
