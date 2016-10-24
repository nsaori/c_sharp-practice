using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat : Animal
    {
        public Cat()
        {
            Age = 0;
            Console.WriteLine("Cat() 생성자");
        }

        public void Meow()
        {
            Console.WriteLine("냥냥 웁니다.");
        }
    }
}
