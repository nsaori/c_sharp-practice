using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    class Management : IManagement
    {
        private List<Person> list;

        public Management(int size) {
            list = new List<Person>(size);
        }
        public Management()
        {
            list = new List<Person>();
        }

        // interface method 구현
        public void Add(Person p) {
            list.Add(p);
        }
        public void Remove(string name) {
            Person p = Search(name);
            list.Remove(p);     //if(p!=NULL)...
        }
        public Person Search(string name) {
            foreach (var item in list)
            {
                if (name == item.Name) {
                    return item;
                }
            }
            return null;
        }
        public List<Person> ToList() {
            return list;
        }
        public void Updata(Person p) {
            Person t = Search(p.Name);  //변경할 사람을 탖아낸다.
            int index = list.IndexOf(t);    //그 사람의 index를 찾는다.
            list.RemoveAt(index);   //그 index에 있는 정보를 지우고
            list.Insert(index,p);   //index에 삽입한다
        }

        
    }
}
