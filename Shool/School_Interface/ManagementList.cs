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
        //-----------------------------------//
        public void Remove(string name)
        {
            Person p = Search(name);
            if(p!=null) list.Remove(p);
        }
        public void Update(Person p)
        {
            Person old = Search(p.Name);
            if (old != null)
            {
                int index = list.IndexOf(old);
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







