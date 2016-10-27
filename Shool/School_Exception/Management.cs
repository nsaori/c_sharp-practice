using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Management : IManagement
    {
        private Person[] pa;
        private int index;

        public Management(int size)
        {
            pa = new Person[size];
        }
        public Management()
        {
            pa = new Person[20];
        }

        public void Add(Person p)
        {
            pa[index++] = p;
            //pa[index] = p;
            //index++;
        }
        public Person Search(string name)
        {
            for (int i = 0; i < index; i++)
            {
                string nm = pa[i].Name;
                if (nm.Equals(name))
                {
                    return pa[i];
                }
            }
            return null;
        }
        public void PrintAll()
        {
            for (int i = 0; i < index; i++)
            {
                //pa[i].PrintAll();
                //Console.WriteLine(pa[i].ToString());
                Console.WriteLine(pa[i]);
            }
        }
        //-----------------------------------//
        public void Remove(string name)
        {
            for (int i = 0; i < index; i++)
            {
                if(name.Equals(pa[i].Name))
                {
                    Array.Copy(pa, i + 1, pa, i, index - 1 - i);
                    pa[--index] = null;
                    break;
                }
            }
        }
        public void Update(Person p)
        {
            for (int i = 0; i < index; i++)
            {
                if (p.Name.Equals(pa[i].Name))
                {
                    pa[i] = p;
                    break;
                }
            }
        }
        public List<Person> ToList()
        {
            List<Person> temp = new List<Person>();
            for (int i = 0; i < index; i++)
            {
                temp.Add(pa[i]);
            }
            return temp;
        }
    }
}







