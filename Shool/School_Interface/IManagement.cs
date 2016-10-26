using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface IManagement
    {
        void Add(Person p);
        Person Search(string name);
        void PrintAll();
        //-----------------------//
        void Remove(string name);
        void Update(Person p);
        List<Person> ToList();
    }
}
