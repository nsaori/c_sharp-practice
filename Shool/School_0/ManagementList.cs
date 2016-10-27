//interface 상속받은 것
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class ManagementList : IManagement
    {
        private List<Person> list;
        
        public ManagementList(int size)
        {
            list = new List<Person>(size);
        }
        public ManagementList()
        {
            list = new List<Person>();
        }

        public void Add(Person p)
        {
            list.Add(p);
        }
        public Person Search(string name)
        {
            foreach (var item in list)
            {
                if(name.Equals(item.Name)) return item;
            }
            return null;
        }
        public void PrintAll()
        {
            foreach (var item in list) Console.WriteLine(item);
        }
        //-----------------------------------//CRUD -Creat,replace,updata,delete
        public void Remove(string name)
        {
            Person p = Search(name);
            if (p != null) list.Remove(p);
            //throw new NotImplementedException();
        }
        public void Update(Person p)  //주소갑을 가라끼운다.
        {
            Person old = Search(p.Name);
            if (old != null) {
                int index = list.IndexOf(old);      //replace,updata는 이렇게 한다---
                list.RemoveAt(index);
                list.Insert(index, p);
            }
        }
        public List<Person> ToList()
        {
            return list;
        }
    }
}







