//p.491

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DElegateRand
{
    class Student
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public Student(string name, double score) {
            Name = name;
            Score = score;
        }
        public string ToString() {
            return this.Name + " : " + this.Score;
        }
    }
    class Students
    {
        private List<Student> listOfStudent = new List<Student>();
        public delegate void PrintProcess(Student list);
        public void Add(Student student) {
            listOfStudent.Add(student);
        }
        public void Print() {
            Print((student) => { Console.WriteLine(student); });
        }

        public void Print(PrintProcess p)
        {
            foreach (var item in listOfStudent)
            {
                p(item);    // = (item) => { Console.WriteLine(item); })
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("윤인성", 4.2));
            students.Add(new Student("연하진", 4.4));

            students.Print();
            //1.mrthod
            students.Print(NameScore);
            
            //2.delegate
            students.Print(delegate (Student s)
            {
                Console.WriteLine();
                Console.WriteLine("이름: " + s.Name);
                Console.WriteLine("학점: " + s.Score);
            });
            //3.Landa
            students.Print((Student) =>
            {
                Console.WriteLine();
                Console.WriteLine("이름: " + Student.Name);
                Console.WriteLine("학점: " + Student.Score);
            });
        }
        //1-2.mrthod
        private static void NameScore(Student s)
        {
            Console.WriteLine();
            Console.WriteLine("이름: " + s.Name);
            Console.WriteLine("학점: " + s.Score);
        }

        
    }
}
