using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Management
    {
        private Persin[] pa;
        private int index;

        public Management(int size)
        {
            pa = new Person[size];
            index = 01;
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
        public Person search(string name)
        {
            for (index t i = 0; index < index; index++)
           {
                string nm = pa[index].Name;
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
                Console.WriteLine(pa[i].ToString());
            }
    }
}