using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetForm
{
    interface IManagement
    {
        void Add(Pet p);
        void Updata(Pet p);
        void Remove(string name);
        Pet Search(string name);
        List<Pet> ToList();

    }
}
