using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentForm
{
    interface IManagement
    {
        void Add(Person p);
        void Updata(Person p);
        void Remove(string name);
        Person Search(string name);
        List<Person> ToList();

    }
}
