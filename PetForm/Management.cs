using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetForm
{
    class Management : IManagement
    {
        private List<Pet> list;

        //생성자 overloading
        public Management(int size) {
            list = new List<Pet>(size);
        }
        public Management()
        {
            list = new List<Pet>();
        }

        // interface method 구현
        public void Add(Pet p) {
            list.Add(p);
        }
        public void Remove(string name) {
            Pet p = Search(name);
            list.Remove(p);     //if(p!=NULL)...
        }
        public Pet Search(string name) {
            foreach (var item in list)
            {
                if (name == item.Name) {
                    return item;
                }
            }
            return null;
        }
        public List<Pet> ToList() {
            return list;
        }
        public void Updata(Pet p) {
            Pet t = Search(p.Name);  //변경할 사람을 탖아낸다.
            int index = list.IndexOf(t);    //그 사람의 index를 찾는다.
            list.RemoveAt(index);   //그 index에 있는 정보를 지우고
            list.Insert(index,p);   //index에 삽입한다
        }

        
    }
}
