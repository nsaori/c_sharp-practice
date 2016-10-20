//20161020 노다 사오리
//ch5 Class p.219~  클래스 응용
//remove하는 순간 indwx도 다시 조정된다.
//list에서 삭제할 떈 역foe문으로!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassUses
{
    class Student
    {
        public string name;
        public int grade;
    }
    class ElementRemove
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            Student s1 = new Student();
            s1.name = "운일성";
            s1.grade = 1;
            list.Add(s1);

            Student s2 = new Student() { name = "연하진", grade = 2 };
            list.Add(s2);

            Student s3 = new Student() { name = "윤아린", grade = 3};
            list.Add(s3);

            list.Add(new Student() { name = "윤명원", grade = 4 });
            list.Add(new Student() { name = "구지연", grade = 1 });
            list.Add(new Student() { name = "김연와", grade = 2 });

            /* foreach로 추가 삭제는 안된다.
            foreach (var item in list)
            {
                if(item.grade > 1)
                {
                    list.Remove(item);
                }
            }
            */
            // for (int i = 0; i < list.Count; i++)
            for (int i = list.Count-1 ; i >= 0; i--)  //list에서 삭제할 떈 역foe문으로!! //list.count -1; ㄴ-1!!
            {
                if (list[i].grade > 1) {
                    list.RemoveAt(i);     //remove하는 순간 indwx도 다시 조정된다.
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }
    }
}
