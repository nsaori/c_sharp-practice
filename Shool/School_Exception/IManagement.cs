using System.Collections.Generic;

namespace School
{
    interface IManagement            // CRUD
    {
        void Add(Person p);          // C        
        Person Search(string name);  // R
        void PrintAll();
        //-----------------------//
        void Remove(string name);    // D
        void Update(Person p);       // U
        List<Person> ToList();
    }
}
