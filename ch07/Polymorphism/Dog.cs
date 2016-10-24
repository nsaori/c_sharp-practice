using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Dog : Animal
    {
        
        public string Color { get; set; }

        public Dog()
        {
            Console.WriteLine("Dog() 생성자");
        }

        public void Bark()
        {
            Console.WriteLine("왈왈 짓습니다.");
        }

        public string ToString() {
            return "멍멍이";
        }
    }
}
