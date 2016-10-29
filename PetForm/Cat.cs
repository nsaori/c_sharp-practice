using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetForm
{
    class Cat:Pet
    {
        public string Breeds { get; set; }

        public Cat(string name, int age, string breeds)  : base(name,age)
        {
            Breeds = breeds;
        }
        public Cat(string name) : base(name)
        {
            Breeds = "뭐냥";
        }
        public Cat() : base()
        {
            Breeds = "뭐냥";
        }
        public override string ToString()
        {
            return "고양이" + "\t" + base.ToString() + "\t" + Breeds;
        }
    }
}
