//~interafce~
//api,speck
//빈 껕떼기

//CRUD = Managemate  (놓고, 조회, 압데이터, 삭제)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    interface IManagement   //CRUD = Managemate
    {
        void Add(Person p);     //C
        Person Search(string name);    //R
        void PrintAll();
        //-----------------------//
        void Remove(string name);   //D
        void Update(Person p);      //U
        List<Person> ToList();
    }
}
